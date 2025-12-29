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
            uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.LeftUp, OnUpPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.LeftRight, OnRightPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.LeftDown, OnDownPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.LeftLeft, OnLeftPerformed);
          
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.LeftUp, OnUpCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.LeftRight, OnRightCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.LeftDown, OnDownCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.LeftLeft, OnLeftCanceled);
          }
          break;

        case PlayerType.Right:
          {
            uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.RightUp, OnUpPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.RightRight, OnRightPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.RightDown, OnDownPerformed);
            uiInputActionManager.SubscribePerformedEvent(UIInputDirectionType.RightLeft, OnLeftPerformed);
          
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.RightUp, OnUpCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.RightRight, OnRightCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.RightDown, OnDownCanceled);
            uiInputActionManager.SubscribeCanceledEvent(UIInputDirectionType.RightLeft, OnLeftCanceled);
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
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.LeftUp, OnUpPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.LeftRight, OnRightPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.LeftDown, OnDownPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.LeftLeft, OnLeftPerformed);

            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.LeftUp, OnUpCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.LeftRight, OnRightCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.LeftDown, OnDownCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.LeftLeft, OnLeftCanceled);
          }
          break;

        case PlayerType.Right:
          {
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.RightUp, OnUpPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.RightRight, OnRightPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.RightDown, OnDownPerformed);
            uiInputActionManager.UnsubscribePerformedEvent(UIInputDirectionType.RightLeft, OnLeftPerformed);

            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.RightUp, OnUpCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.RightRight, OnRightCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.RightDown, OnDownCanceled);
            uiInputActionManager.UnsubscribeCanceledEvent(UIInputDirectionType.RightLeft, OnLeftCanceled);
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
      => onCanceled?.Invoke(Direction.Up);
  }
}
