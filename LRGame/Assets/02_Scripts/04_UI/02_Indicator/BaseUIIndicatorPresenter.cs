using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UniRx;
using UnityEngine;
using UnityEngine.UI;
using static LR.UI.Indicator.IUIIndicatorPresenter;

namespace LR.UI.Indicator
{
  public class BaseUIIndicatorPresenter : IUIIndicatorPresenter
  {
    private const float BlockedAlpha = 1.0f;
    private const float MovableAlpha = 0.2f;

    private const float EnableAlpha = 1.0f;
    private const float DisableAlpha = 0.0f;

    private const float BlinkInterval = 0.3f;

    private readonly BaseUIIndicatorView view;
    private readonly CTSContainer moveCTS = new();
    private readonly CTSContainer blinkCTS = new();

    private UniTask blinkTask;

    public BaseUIIndicatorPresenter(Transform root, IRectView targetRect, BaseUIIndicatorView view)
    {
      this.view = view;
      view.gameObjectView.SetRoot(root);
      view.rectView.SetPosition(targetRect.GetPosition());
      view.rectView.SetRect(targetRect.GetCurrentRectSize());
    }

    public void ReInitialize(Transform root, IRectView targetRectView)
    {
      view.gameObjectView.SetRoot(root);
      view.rectView.SetPosition(targetRectView.GetPosition());
      view.rectView.SetRect(targetRectView.GetCurrentRectSize());      
    }

    public void Disable(Transform disabledRoot)
    {
      view.gameObjectView.SetRoot(disabledRoot);
      moveCTS.Cancel();
      blinkCTS.Cancel();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if(view)
      view.gameObjectView.DestroyGameObject();

      moveCTS.Dispose();
      blinkCTS.Dispose();
    }

    public async UniTask MoveAsync(IRectView targetRect, bool isImmediately = false)
    {
      moveCTS.Cancel();

      var targetPosition = targetRect.GetCenterPosition();
      var targetRectSize = targetRect.GetCurrentRectSize();

      if (isImmediately)
      {
        view.rectView.SetPosition(targetPosition);
        view.rectView.SetRect(targetRectSize);
        await UniTask.CompletedTask;
      }
      else
      {
        moveCTS.Create();

        var targetDuration = GlobalManager.instance.Table.UISO.IndicatorDuration;
        var time = 0.0f;

        var currentPosition = view.transform.position;
        var currentRectsize = view.rectView.GetCurrentRectSize();

        var token = moveCTS.token;
        try
        {
          while (time < targetDuration)
          {
            token.ThrowIfCancellationRequested();
            var t = time / targetDuration;
            view.rectView.SetPosition(Vector2.Lerp(currentPosition, targetPosition, t));
            view.rectView.SetRect(Vector2.Lerp(currentRectsize, targetRectSize, t));

            time += Time.deltaTime;
            await UniTask.Yield(PlayerLoopTiming.Update);
          }
          view.rectView.SetPosition(targetPosition);
          view.rectView.SetRect(targetRectSize);
        }
        catch (OperationCanceledException) { }
      }
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public UIVisibleState GetVisibleState()
    {
      throw new NotImplementedException();
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }
    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public void SetLeftGuide(Direction direction, LeftGuideType guideType)
    {
      SetLeftGuide(new Dictionary<Direction, LeftGuideType>() 
      { 
        { direction, guideType} 
      });
    }

    public void SetLeftGuide(Navigation navigation)
    {
      var set = new Dictionary<Direction, LeftGuideType>();

      if (navigation.selectOnUp != null)
        set[Direction.Up] = LeftGuideType.Movable;
      if (navigation.selectOnRight != null)
        set[Direction.Right] = LeftGuideType.Movable;
      if (navigation.selectOnDown != null)
        set[Direction.Down] = LeftGuideType.Movable;
      if (navigation.selectOnLeft != null)
        set[Direction.Left] = LeftGuideType.Movable;

      SetLeftGuide(set);
    }

    public async void SetLeftGuide(Dictionary<Direction, LeftGuideType> guideSets)
    {
      var allImageViews = GetLeftGuideViewList();

      var movableImageViews = new List<BaseImageView>();
      var blinkImageViews = new List<BaseImageView>();

      guideSets ??= new Dictionary<Direction, LeftGuideType>();
      foreach (var pair in guideSets)
      {
        var directionImageView = GetLeftGuideView(pair.Key);
        allImageViews.Remove(directionImageView);

        var targetList = pair.Value switch
        {
          LeftGuideType.Movable => movableImageViews,
          LeftGuideType.Clamped => blinkImageViews,
          _ => throw new NotImplementedException(),
        };
        targetList.Add(directionImageView);
      }

      blinkCTS.Cancel();

      foreach(var joblessImageViews in  allImageViews)
        joblessImageViews.SetAlpha(BlockedAlpha);

      foreach (var movableImageView in movableImageViews)
        movableImageView.SetAlpha(MovableAlpha);

      if(blinkImageViews.Count > 0)
      {
        try
        {
          await blinkTask.SuppressCancellationThrow();
        }
        catch { }

        blinkCTS.Create();
        blinkTask = BlinkImageViews(blinkImageViews);
        blinkTask.Forget();
      }        
    }

    public void SetRightGuide(params Direction[] directions)
    {
      GetRightGuideViews(directions.ToList(), out var targetViews, out var elseViews);

      foreach (var targetView in targetViews)
        targetView.SetAlpha(EnableAlpha);

      foreach (var elseView in elseViews)
        elseView.SetAlpha(DisableAlpha);
    }

    private List<BaseImageView> GetLeftGuideViewList()
      => new() { view.leftUpImageView, view.leftDownImageView, view.leftRightImageView, view.leftLeftImageView };

    private BaseImageView GetLeftGuideView(Direction direction)
      => direction switch
      {
        Direction.Up => view.leftUpImageView,
        Direction.Down => view.leftDownImageView,
        Direction.Left => view.leftLeftImageView,
        Direction.Right => view.leftRightImageView,
        Direction.Space => throw new NotImplementedException("LeftSpace Image is not Exit!"),
        _ => throw new NotImplementedException()
      };

    private async UniTask BlinkImageViews(List<BaseImageView> imageViews)
    {
      try
      {
        var token = blinkCTS.token;
        var isBlockAlpha = false;
        while (token.IsCancellationRequested == false)
        {
          token.ThrowIfCancellationRequested();
          foreach (var imageView in imageViews)
            imageView.SetAlpha(isBlockAlpha ? BlockedAlpha
                                            : MovableAlpha);

          await UniTask.WaitForSeconds(BlinkInterval, false, PlayerLoopTiming.Update, token);
          isBlockAlpha = !isBlockAlpha;
        }
      }
      catch (OperationCanceledException)
      {
        
      }
      finally
      {
        
      }
    }

    private void GetRightGuideViews(
        List<Direction> directions,
        out List<BaseImageView> targetViews,
        out List<BaseImageView> elseViews)
    {
      targetViews = new();
      elseViews = new();

      var map = new Dictionary<Direction, BaseImageView>
    {
        { Direction.Up,    view.rightUpImageView },
        { Direction.Right, view.rightRightImageView },
        { Direction.Down,  view.rightDownImageView },
        { Direction.Left,  view.rightLeftImageView },
        { Direction.Space, view.spaceImageView }
    };

      foreach (var (dir, img) in map)
      {
        if (directions.Contains(dir))
          targetViews.Add(img);
        else
          elseViews.Add(img);
      }
    }
  }
}