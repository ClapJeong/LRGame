using Cysharp.Threading.Tasks;
using LR.UI;
using LR.UI.GameScene.Dialogue.Root;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI;

namespace LR.UI.GameScene.Dialogue
{
  public class UIDialogueRootPresenter : IUIPresenter
  {
    public class Model
    {
      public TableContainer table;
      public IResourceManager resourceManager;
      public IGameDataService gameDataService;
      public IUIInputActionManager uiInputActionManager;
      public IDialogueDataProvider dialogueDataProvider;
      public IDialogueSubscriber subscriber;
      public IDialogueController controller;
      public IStageStateHandler stageStateHandler;

      public Model(TableContainer table, IResourceManager resourceManager, IGameDataService gameDataService, IUIInputActionManager uiInputActionManager, IDialogueDataProvider dialogueDataProvider, IDialogueSubscriber subscriber, IDialogueController controller, IStageStateHandler stageStateHandler)
      {
        this.table = table;
        this.resourceManager = resourceManager;
        this.gameDataService = gameDataService;
        this.uiInputActionManager = uiInputActionManager;
        this.dialogueDataProvider = dialogueDataProvider;
        this.subscriber = subscriber;
        this.controller = controller;
        this.stageStateHandler = stageStateHandler;
      }
    }

    private readonly Model model;
    private readonly UIDialogueRootView view;

    private readonly UIDialogueCharacterPresenter leftPresenter;
    private readonly UIDialogueCharacterPresenter centerPresenter;
    private readonly UIDialogueCharacterPresenter rightPresenter;
    private readonly UIDialogueInputsPresenter inputPresenter;
    private readonly SequenceController sequenceController;

    public UIDialogueRootPresenter(Model model, UIDialogueRootView view)
    {
      this.model = model;
      this.view = view;

      var leftModel = new UIDialogueCharacterPresenter.Model(
        this.model.table.AddressableKeySO.PortraitName,
        UIDialogueCharacterPresenter.CharacterType.Left,
        this.model.resourceManager,
        this.model.table.AddressableKeySO.Path.LeftPortrait,
        this.model.table.DialogueDataSO.PortraitData,
        this.model.table.DialogueDataSO.TextPresentationData);
      this.leftPresenter = new UIDialogueCharacterPresenter(leftModel, view.leftView);

      var centerModel = new UIDialogueCharacterPresenter.Model(
        this.model.table.AddressableKeySO.PortraitName,
        UIDialogueCharacterPresenter.CharacterType.Center,
        this.model.resourceManager,
        this.model.table.AddressableKeySO.Path.CenterPortrait,
        this.model.table.DialogueDataSO.PortraitData,
        this.model.table.DialogueDataSO.TextPresentationData);
      this.centerPresenter = new UIDialogueCharacterPresenter(centerModel, view.centerView);

      var rightModel = new UIDialogueCharacterPresenter.Model(
        this.model.table.AddressableKeySO.PortraitName,
        UIDialogueCharacterPresenter.CharacterType.Right,
        this.model.resourceManager,
        this.model.table.AddressableKeySO.Path.RightPortrait,
        this.model.table.DialogueDataSO.PortraitData,
        this.model.table.DialogueDataSO.TextPresentationData);
      this.rightPresenter = new UIDialogueCharacterPresenter(rightModel, view.rightView);

      var inputModel = new UIDialogueInputsPresenter.Model(
        this.model.table.DialogueDataSO.TextPresentationData);
      this.inputPresenter = new UIDialogueInputsPresenter(inputModel, view.inputView);

      sequenceController = new(
        this.model.table,
        this.model.gameDataService,
        this.model.uiInputActionManager,
        this.model.dialogueDataProvider,
        this.model.subscriber,
        this.model.controller,
        this.model.stageStateHandler,
        this,
        this.leftPresenter,
        this.centerPresenter,
        this.rightPresenter,
        this.inputPresenter);
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmedieately, token);
    }


    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.HideAsync(isImmedieately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      sequenceController.Dispose();
      if (view)
        view.DestroySelf();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();
  }
}
