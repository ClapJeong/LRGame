using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using LR.UI.GameScene.Dialogue.Selection;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI.GameScene.Dialogue
{
  public class UISelectionCharacterPresenter : IUIPresenter
  {
    public class Model
    {
      public PlayerType playerType;
      public UITextPresentationData textPresentationData;
      public IUIInputActionManager uiInputActionManager;
      public UnityAction<Direction> onSelect;
      public UnityAction<Direction> onCanceled;

      public Model(PlayerType playerType, UITextPresentationData textPresentationData, IUIInputActionManager uiInputActionManager, UnityAction<Direction> onSelect, UnityAction<Direction> onCanceled)
      {
        this.playerType = playerType;
        this.textPresentationData = textPresentationData;
        this.uiInputActionManager = uiInputActionManager;
        this.onSelect = onSelect;
        this.onCanceled = onCanceled;
      }
    }

    private readonly Model model;
    private readonly UISelectionCharacterView view;

    private readonly InputEventHolder inputEventHolder;
    private readonly SubscribeHandle subscribeHandle;


    public UISelectionCharacterPresenter(Model model, UISelectionCharacterView view)
    {
      this.model = model;
      this.view = view;

      inputEventHolder = new(
        model.uiInputActionManager,
        model.playerType,
        OnInputPerformed,
        OnInputCanceled);

      subscribeHandle = new(inputEventHolder.SubscribeInputActions, inputEventHolder.UnsubscribeInputActions);
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      subscribeHandle.Subscribe();
      await view.ShowAsync(isImmedieately, token);
    }

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmedieately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
      if (view)
        view.DestroySelf();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    public void SetStrings(DialogueSelectionData data)
    {
      switch (model.playerType)
      {
        case PlayerType.Left:
          {
            view.upLocalize.SetEntry(data.LeftUpKey);
            view.rightLocalize.SetEntry(data.LeftRightKey);
            view.downLocalize.SetEntry(data.LeftDownKey);
            view.leftLocalize.SetEntry(data.LeftLeftKey);
          }
          break;

        case PlayerType.Right:
          {
            view.upLocalize.SetEntry(data.RightUpKey);
            view.rightLocalize.SetEntry(data.RightRightKey);
            view.downLocalize.SetEntry(data.RightDownKey);
            view.leftLocalize.SetEntry(data.RightLeftKey);
          }
          break;

        default: throw new NotImplementedException();
      }
    }

    public void SetOutlinePosition(Direction direction)
    {
      view.outlineRect.position = view.GetDirectionPosition(direction);
    }

    private void OnInputPerformed(Direction direction)
    {
      model.onSelect?.Invoke(direction);
    }

    private void OnInputCanceled(Direction direction) 
    {
      model.onCanceled?.Invoke(direction);
    }
  }
}