using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.Indicator
{
  public class BaseUIIndicatorPresenter : IUIIndicatorPresenter
  {
    private readonly BaseUIIndicatorView view;
    private readonly CTSContainer cts = new();

    public BaseUIIndicatorPresenter(Transform root, IRectView targetRect, BaseUIIndicatorView view)
    {
      this.view = view;
      view.SetRoot(root);
      view.SetPosition(targetRect.GetPosition());
      view.SetRect(targetRect.GetCurrentRectSize());
    }

    public void ReInitialize(Transform root, IRectView targetRectView)
    {
      view.SetRoot(root);
      view.SetPosition(targetRectView.GetPosition());
      view.SetRect(targetRectView.GetCurrentRectSize());      
    }

    public void Disable(Transform disabledRoot)
    {
      view.SetRoot(disabledRoot);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target
      .OnDestroyAsObservable()
      .Subscribe(_ => Dispose());

    public void Dispose()
    {
      view?.DestroyGameObject();
    }

    public async UniTask MoveAsync(IRectView targetRect, bool isImmediately = false)
    {
      cts.Cancel(regenerate: true);

      var targetPosition = targetRect.GetPosition();
      var targetRectSize = targetRect.GetCurrentRectSize();

      if (isImmediately)
      {
        view.SetPosition(targetPosition);
        view.SetRect(targetRectSize);
        await UniTask.CompletedTask;
      }
      else
      {
        var targetDuration = GlobalManager.instance.Table.UISO.IndicatorDuration;
        var time = 0.0f;

        var currentPosition = view.transform.position;
        var currentRectsize = view.GetCurrentRectSize();
        try
        {
          while (time < targetDuration)
          {
            cts.token.ThrowIfCancellationRequested();
            var t = time / targetDuration;
            view.SetPosition(Vector2.Lerp(currentPosition, targetPosition, t));
            view.SetRect(Vector2.Lerp(currentRectsize, targetRectSize, t));

            time += Time.deltaTime;
            await UniTask.Yield(PlayerLoopTiming.Update);
          }
          view.SetPosition(targetPosition);
          view.SetRect(targetRectSize);
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
  }
}