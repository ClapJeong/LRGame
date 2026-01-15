using UnityEngine.Events;
using LR.Stage.Player.Enum;
using LR.UI.Enum;

namespace LR.UI.GameScene.Dialogue.Selection
{
  public class InputEventHolder
  {
    private readonly IUIInputManager uiInputActionManager;
    private readonly PlayerType playerType;
    private readonly UnityAction<Direction> onPerformed;
    private readonly UnityAction<Direction> onCanceled;

    public InputEventHolder(IUIInputManager uiInputActionManager, PlayerType playerType, UnityAction<Direction> onPerformed, UnityAction<Direction> onCanceled)
    {
      this.uiInputActionManager = uiInputActionManager;
      this.playerType = playerType;
      this.onPerformed = onPerformed;
      this.onCanceled = onCanceled;
    }

    public void SubscribeInputActions()
    {
      switch (playerType)
      {
        case PlayerType.Left:
          {
            uiInputActionManager.SubscribePerformedEvent(InputDirection.LeftUp, OnUpPerformed);
            uiInputActionManager.SubscribePerformedEvent(InputDirection.LeftRight, OnRightPerformed);
            uiInputActionManager.SubscribePerformedEvent(InputDirection.LeftDown, OnDownPerformed);
            uiInputActionManager.SubscribePerformedEvent(InputDirection.LeftLeft, OnLeftPerformed);
          
            uiInputActionManager.SubscribeCanceledEvent(InputDirection.LeftUp, OnUpCanceled);
            uiInputActionManager.SubscribeCanceledEvent(InputDirection.LeftRight, OnRightCanceled);
            uiInputActionManager.SubscribeCanceledEvent(InputDirection.LeftDown, OnDownCanceled);
            uiInputActionManager.SubscribeCanceledEvent(InputDirection.LeftLeft, OnLeftCanceled);
          }
          break;

        case PlayerType.Right:
          {
            uiInputActionManager.SubscribePerformedEvent(InputDirection.RightUp, OnUpPerformed);
            uiInputActionManager.SubscribePerformedEvent(InputDirection.RightRight, OnRightPerformed);
            uiInputActionManager.SubscribePerformedEvent(InputDirection.RightDown, OnDownPerformed);
            uiInputActionManager.SubscribePerformedEvent(InputDirection.RightLeft, OnLeftPerformed);
          
            uiInputActionManager.SubscribeCanceledEvent(InputDirection.RightUp, OnUpCanceled);
            uiInputActionManager.SubscribeCanceledEvent(InputDirection.RightRight, OnRightCanceled);
            uiInputActionManager.SubscribeCanceledEvent(InputDirection.RightDown, OnDownCanceled);
            uiInputActionManager.SubscribeCanceledEvent(InputDirection.RightLeft, OnLeftCanceled);
          }
          break;
      }
    }

    public void UnsubscribeInputActions()
    {
      switch (playerType)
      {
        case PlayerType.Left:
          {
            uiInputActionManager.UnsubscribePerformedEvent(InputDirection.LeftUp, OnUpPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(InputDirection.LeftRight, OnRightPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(InputDirection.LeftDown, OnDownPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(InputDirection.LeftLeft, OnLeftPerformed);

            uiInputActionManager.UnsubscribeCanceledEvent(InputDirection.LeftUp, OnUpCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(InputDirection.LeftRight, OnRightCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(InputDirection.LeftDown, OnDownCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(InputDirection.LeftLeft, OnLeftCanceled);
          }
          break;

        case PlayerType.Right:
          {
            uiInputActionManager.UnsubscribePerformedEvent(InputDirection.RightUp, OnUpPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(InputDirection.RightRight, OnRightPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(InputDirection.RightDown, OnDownPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(InputDirection.RightLeft, OnLeftPerformed);

            uiInputActionManager.UnsubscribeCanceledEvent(InputDirection.RightUp, OnUpCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(InputDirection.RightRight, OnRightCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(InputDirection.RightDown, OnDownCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(InputDirection.RightLeft, OnLeftCanceled);
          }
          break;
      }
    }

    private void OnUpPerformed()
      => onPerformed?.Invoke(Direction.Up);

    private void OnUpCanceled()
      => onCanceled?.Invoke(Direction.Up);

    private void OnRightPerformed()
      => onPerformed?.Invoke(Direction.Right);

    private void OnRightCanceled()
      => onCanceled?.Invoke(Direction.Right);

    private void OnDownPerformed()
      => onPerformed?.Invoke(Direction.Down);

    private void OnDownCanceled()
      => onCanceled?.Invoke(Direction.Down);

    private void OnLeftPerformed()
      => onPerformed?.Invoke(Direction.Left);

    private void OnLeftCanceled()
      => onCanceled?.Invoke(Direction.Left);
  }
}
