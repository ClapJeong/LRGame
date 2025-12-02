using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.GameScene.Player
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
      IPlayerInputActionController leftInputController,
      UIPlayerInputViewContainer rightViewContainer,
      IPlayerInputActionController rightInputController)
    {
      this.model = model;
      this.leftViewContainer = leftViewContainer;
      this.rightViewContainer = rightViewContainer;

      leftInputController.SubscribeOnPerformed(direction=>
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
      leftInputController.SubscribeOnCanceled(direction =>
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
      rightInputController.SubscribeOnPerformed(direction =>
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
      rightInputController.SubscribeOnCanceled(direction =>
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
    }
  }
}