using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UniRx;
using UniRx.Triggers;
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

    private readonly UISO uiSO;
    private readonly Transform disableRoot;
    private readonly BaseUIIndicatorView view;

    private readonly CTSContainer moveCTS = new();
    private readonly CTSContainer blinkCTS = new();

    private RectTransform prevTarget;
    private RectTransform currentTarget;
    private float followT = 1.0f;
    private UniTask blinkTask;

    public BaseUIIndicatorPresenter(Transform root, RectTransform targetRect, BaseUIIndicatorView view, Transform disableRoot)
    {
      this.uiSO = GlobalManager.instance.Table.UISO;
      this.view = view;
      this.disableRoot = disableRoot;

      currentTarget = targetRect;
      view.transform.SetParent(root);
      view.RectTransform.position = currentTarget.GetCenterPosition();
      view.RectTransform.SetSize(currentTarget.rect.size);
      view.RectTransform.localScale = currentTarget.localScale;

      var updateDisposable = view.UpdateAsObservable().Subscribe(_ =>
      {
        if (currentTarget == null)
          return;

        if (followT < 1.0f)
        {
          var position = Vector3.Lerp(prevTarget.GetCenterPosition(), currentTarget.GetCenterPosition(), followT);
          view.RectTransform.position = position;
          var rectSize = Vector2.Lerp(prevTarget.rect.size, currentTarget.rect.size, followT);
          view.RectTransform.SetSize(rectSize);
          var scale = Vector3.Lerp(prevTarget.localScale, currentTarget.localScale, followT);
          view.RectTransform.localScale = scale;
        }
        else
        {
          view.RectTransform.position = currentTarget.GetCenterPosition();
          view.RectTransform.SetSize(currentTarget.rect.size);
          view.RectTransform.localScale = currentTarget.localScale;
        }
      });
      view.OnDestroyAsObservable().Subscribe(_ => updateDisposable.Dispose());
    }

    public void ReInitialize(Transform root, RectTransform targetRect)
    {
      moveCTS.Cancel();
      followT = 1.0f;
      currentTarget = targetRect;

      view.transform.SetParent(root);      
      view.RectTransform.position = currentTarget.GetCenterPosition();
      view.RectTransform.SetSize(currentTarget.rect.size);
      view.RectTransform.localScale = currentTarget.localScale;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (view)
        view.DestroySelf();

      moveCTS.Dispose();
      blinkCTS.Dispose();
    }

    public async UniTask MoveAsync(RectTransform targetRect, bool isImmediately = false)
    {
      moveCTS.Cancel();

      if (isImmediately)
      {
        currentTarget = targetRect;
        followT = 1.0f;

        view.RectTransform.position = currentTarget.GetCenterPosition();
        view.RectTransform.SetSize(currentTarget.rect.size);
        view.RectTransform.localScale = currentTarget.localScale;
      }
      else
      {
        moveCTS.Create();
        var token = moveCTS.token;
        await ChangeFollowTargetAsync(targetRect, token);
      }
    }


    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {      
      moveCTS.Cancel();
      blinkCTS.Cancel();
      await view.HideAsync(isImmediately, token);
      view.transform.SetParent(disableRoot);
    }

    #region LeftInputGuide
    public void SetLeftInputGuide(Direction direction, LeftInputGuideType guideType)
    {
      SetLeftInputGuide(new Dictionary<Direction, LeftInputGuideType>() 
      { 
        { direction, guideType} 
      });
    }

    public void SetLeftInputGuide(Navigation navigation)
    {
      var set = new Dictionary<Direction, LeftInputGuideType>();

      if (navigation.selectOnUp != null)
        set[Direction.Up] = LeftInputGuideType.Movable;
      if (navigation.selectOnRight != null)
        set[Direction.Right] = LeftInputGuideType.Movable;
      if (navigation.selectOnDown != null)
        set[Direction.Down] = LeftInputGuideType.Movable;
      if (navigation.selectOnLeft != null)
        set[Direction.Left] = LeftInputGuideType.Movable;

      SetLeftInputGuide(set);
    }

    public async void SetLeftInputGuide(Dictionary<Direction, LeftInputGuideType> guideSets)
    {
      var allImageViews = GetLeftGuideViewList();

      var movableImageViews = new List<Image>();
      var blinkImageViews = new List<Image>();

      guideSets ??= new Dictionary<Direction, LeftInputGuideType>();
      foreach (var pair in guideSets)
      {
        var directionImageView = GetLeftGuideView(pair.Key);
        allImageViews.Remove(directionImageView);

        var targetList = pair.Value switch
        {
          LeftInputGuideType.Movable => movableImageViews,
          LeftInputGuideType.Clamped => blinkImageViews,
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
    #endregion

    #region RightInputGuide
    public void SetRightInputGuide(params Direction[] directions)
    {
      directions ??= new Direction[0];
      GetRightGuideViews(directions.ToList(), out var targetViews, out var elseViews);

      foreach (var targetView in targetViews)
        targetView.SetAlpha(EnableAlpha);

      foreach (var elseView in elseViews)
        elseView.SetAlpha(DisableAlpha);
    }
    #endregion

    private async UniTask ChangeFollowTargetAsync(RectTransform newTarget, CancellationToken token)
    {
      try
      {
        prevTarget = currentTarget;
        currentTarget = newTarget;
        var duration = 0.0f;
        while (duration < uiSO.IndicatorDuration)
        {
          duration += Time.deltaTime;
          followT = duration / uiSO.IndicatorDuration;
          await UniTask.Yield();
        }
        followT = 1.0f;
      }
      catch (OperationCanceledException)
      {

      }
    }

    private List<Image> GetLeftGuideViewList()
      => new() { view.leftUpImage, view.leftDownImage, view.leftRightImage, view.leftLeftImage };

    private Image GetLeftGuideView(Direction direction)
      => direction switch
      {
        Direction.Up => view.leftUpImage,
        Direction.Down => view.leftDownImage,
        Direction.Left => view.leftLeftImage,
        Direction.Right => view.leftRightImage,
        Direction.Space => throw new NotImplementedException("LeftSpace Image is not Exit!"),
        _ => throw new NotImplementedException()
      };

    private async UniTask BlinkImageViews(List<Image> imageViews)
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
        out List<Image> targetViews,
        out List<Image> elseViews)
    {
      targetViews = new();
      elseViews = new();

      var map = new Dictionary<Direction, Image>
    {
        { Direction.Up,    view.rightUpImage },
        { Direction.Right, view.rightRightImage },
        { Direction.Down,  view.rightDownImage },
        { Direction.Left,  view.rightLeftImage },
        { Direction.Space, view.spaceImage }
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