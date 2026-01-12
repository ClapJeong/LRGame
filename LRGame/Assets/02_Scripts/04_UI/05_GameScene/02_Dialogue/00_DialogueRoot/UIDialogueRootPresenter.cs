using Cysharp.Threading.Tasks;
using LR.UI.GameScene.Dialogue.Root;
using System;
using System.Threading;
using UnityEngine;

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
      public IDialogueStateSubscriber subscriber;
      public IDialogueStateController controller;
      public IStageStateHandler stageStateHandler;

      public Model(TableContainer table, IResourceManager resourceManager, IGameDataService gameDataService, IUIInputActionManager uiInputActionManager, IDialogueDataProvider dialogueDataProvider, IDialogueStateSubscriber subscriber, IDialogueStateController controller, IStageStateHandler stageStateHandler)
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

    private readonly SequenceController sequenceController;

    public UIDialogueRootPresenter(Model model, UIDialogueRootView view)
    {
      this.model = model;
      this.view = view;

      sequenceController = new(
        view.gameObject,
        this.model.table,
        this.model.gameDataService,
        this.model.resourceManager,
        this.model.uiInputActionManager,
        this.model.dialogueDataProvider,
        this.model.subscriber,
        this.model.controller,
        this.model.stageStateHandler,
        this,
        view.leftTalkingCharacterView,
        view.centerTalkingCharacterView,
        view.rightTalkingCharacterView,
        view.talkingInputView,
        view.leftSelectionCharacterView,
        view.rightSelectionCharacterView,
        view.selectionTimerView);
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
