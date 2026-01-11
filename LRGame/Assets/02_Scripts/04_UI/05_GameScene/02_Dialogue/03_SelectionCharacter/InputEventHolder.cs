using System.Collections.Generic;
using UnityEngine.Events;

namespace LR.UI.GameScene.Dialogue.Selection
{
  public class InputEventHolder
  {
    private readonly IUIInputActionManager uiInputActionManager;
    private readonly PlayerType playerType;
    private readonly UnityAction<Direction> onPerformed;
    private readonly UnityAction<Direction> onCanceled;

    public InputEventHolder(IUIInputActionManager uiInputActionManager, PlayerType playerType, UnityAction<Direction> onPerformed, UnityAction<Direction> onCanceled)
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
            uiInputActionManager.SubscribePerformedEvent(UIInputDirection.LeftUp, OnUpPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirection.LeftRight, OnRightPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirection.LeftDown, OnDownPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirection.LeftLeft, OnLeftPerformed);
          
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirection.LeftUp, OnUpCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirection.LeftRight, OnRightCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirection.LeftDown, OnDownCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirection.LeftLeft, OnLeftCanceled);
          }
          break;

        case PlayerType.Right:
          {
            uiInputActionManager.SubscribePerformedEvent(UIInputDirection.RightUp, OnUpPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirection.RightRight, OnRightPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirection.RightDown, OnDownPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirection.RightLeft, OnLeftPerformed);
          
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirection.RightUp, OnUpCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirection.RightRight, OnRightCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirection.RightDown, OnDownCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirection.RightLeft, OnLeftCanceled);
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
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirection.LeftUp, OnUpPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirection.LeftRight, OnRightPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirection.LeftDown, OnDownPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirection.LeftLeft, OnLeftPerformed);

            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirection.LeftUp, OnUpCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirection.LeftRight, OnRightCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirection.LeftDown, OnDownCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirection.LeftLeft, OnLeftCanceled);
          }
          break;

        case PlayerType.Right:
          {
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirection.RightUp, OnUpPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirection.RightRight, OnRightPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirection.RightDown, OnDownPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirection.RightLeft, OnLeftPerformed);

            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirection.RightUp, OnUpCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirection.RightRight, OnRightCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirection.RightDown, OnDownCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirection.RightLeft, OnLeftCanceled);
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
