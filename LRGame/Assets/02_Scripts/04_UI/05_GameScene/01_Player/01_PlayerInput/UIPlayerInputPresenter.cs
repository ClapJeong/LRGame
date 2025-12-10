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
      public IPlayerInputActionController inputActionController;

      public Model(IPlayerInputActionController inputActionController)
      {
        this.inputActionController = inputActionController;
      }
    }

    private readonly Model model;
    private readonly UIPlayerInputView view;
    private readonly int activeHash = Animator.StringToHash("Active");

    public UIPlayerInputPresenter(Model model, UIPlayerInputView view)
    {
      this.model = model;
      this.view = view;

      SubscribeInputActionController();
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await view.HideAsync(isImmediately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    public void Dispose()
    {
      UnsubscribeInputActionController();

      if (view)
        view.DestroySelf();
    }

    private void SubscribeInputActionController()
    {
      model.inputActionController.SubscribeOnPerformed(OnInputActionPerformed);
      model.inputActionController.SubscribeOnCanceled(OnInputActionCanceled);
    }
    
    private void UnsubscribeInputActionController()
    {
      model.inputActionController.UnsubscribePerfoemd(OnInputActionPerformed);
      model.inputActionController.UnsubscribeCanceled(OnInputActionCanceled);
    }

    private void OnInputActionPerformed(Direction direction)
    {
      var animatorView = direction switch
      {
        Direction.Up => view.upAnimator,
        Direction.Down => view.downAnimator,
        Direction.Left => view.leftAnimator,
        Direction.Right => view.rightAnimator,
        _ => throw new System.NotImplementedException(),
      };
      animatorView.SetBool(activeHash, true);
    }

    private void OnInputActionCanceled(Direction direction)
    {
      var animatorView = direction switch
      {
        Direction.Up => view.upAnimator,
        Direction.Down => view.downAnimator,
        Direction.Left => view.leftAnimator,
        Direction.Right => view.rightAnimator,
        _ => throw new System.NotImplementedException(),
      };
      animatorView.SetBool(activeHash, false);
    }
  }
}