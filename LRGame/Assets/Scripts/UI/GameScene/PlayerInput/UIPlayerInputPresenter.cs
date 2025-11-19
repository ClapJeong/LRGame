using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.Player
{
  public class UIPlayerInputPresenter : IUIPresenter
  {
    public class Model
    {

    }

    private readonly Model model;
    private readonly UIPlayerInputViewContainer leftViewContainer;
    private readonly UIPlayerInputViewContainer rightViewContainer;
    private readonly int activeHash = Animator.StringToHash("Active");

    public UIPlayerInputPresenter(
      Model model,
      UIPlayerInputViewContainer leftViewContainer,
      IPlayerMoveSubscriber leftSubscriber,
      UIPlayerInputViewContainer rightViewContainer,
      IPlayerMoveSubscriber rightSubscriber)
    {
      this.model = model;
      this.leftViewContainer = leftViewContainer;
      this.rightViewContainer = rightViewContainer;

      leftSubscriber.SubscribeOnPerformed(direction=>
      {
        var view = direction switch
        {
          Direction.Up => leftViewContainer.upView,
          Direction.Down => leftViewContainer.downView,
          Direction.Left => leftViewContainer.leftView,
          Direction.Right => leftViewContainer.rightView,
          _=>throw new System.NotImplementedException(),
        };
        view.SetBool(activeHash, true);
      });
      leftSubscriber.SubscribeOnCanceled(direction =>
      {
        var view = direction switch
        {
          Direction.Up => leftViewContainer.upView,
          Direction.Down => leftViewContainer.downView,
          Direction.Left => leftViewContainer.leftView,
          Direction.Right => leftViewContainer.rightView,
          _ => throw new System.NotImplementedException(),
        };
        view.SetBool(activeHash, false);
      });
      rightSubscriber.SubscribeOnPerformed(direction =>
      {
        var view = direction switch
        {
          Direction.Up => rightViewContainer.upView,
          Direction.Down => rightViewContainer.downView,
          Direction.Left => rightViewContainer.leftView,
          Direction.Right => rightViewContainer.rightView,
          _ => throw new System.NotImplementedException(),
        };
        view.SetBool(activeHash, true);
      });
      rightSubscriber.SubscribeOnCanceled(direction =>
      {
        var view = direction switch
        {
          Direction.Up => rightViewContainer.upView,
          Direction.Down => rightViewContainer.downView,
          Direction.Left => rightViewContainer.leftView,
          Direction.Right => rightViewContainer.rightView,
          _ => throw new System.NotImplementedException(),
        };
        view.SetBool(activeHash, false);
      });
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public UIVisibleState GetVisibleState()
    {
      return UIVisibleState.Showed;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
      IUIPresenterContainer container = GlobalManager.instance.UIManager;
      container.Remove(this);
    }
  }
}