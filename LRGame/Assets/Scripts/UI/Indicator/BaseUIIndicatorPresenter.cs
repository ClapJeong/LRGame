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

    public BaseUIIndicatorPresenter(Transform root, IRectView targetRect, BaseUIIndicatorView view)
    {
      this.view = view;
      view.SetRoot(root);
      view.SetPosition(targetRect.GetPosition());
      view.SetRect(targetRect.GetCurrentRect());
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target
      .OnDestroyAsObservable()
      .Subscribe(_ => Dispose());

    public void Dispose()
    {
      if(view != null) 
        GameObject.Destroy(view.gameObject);
    }


    public async UniTask MoveAsync(IRectView targetRect, bool isImmediately = false, CancellationToken token = default)
    {
      var targetPosition = targetRect.GetPosition();
      var targetRectSize = targetRect.GetCurrentRect();

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
        var currentRectsize = view.GetCurrentRect();
        while (time < targetDuration)
        {
          var t = time / targetDuration;
          view.SetPosition(Vector2.Lerp(currentPosition, targetPosition, t));
          view.SetRect(Vector2.Lerp(currentRectsize, targetRectSize, t));

          time += Time.deltaTime;
          await UniTask.Yield(PlayerLoopTiming.Update);
        }
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