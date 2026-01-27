using LR.Stage.Player;
using LR.Table.Input;
using LR.Table.TriggerTile;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class InputtingEnergyItemTriggerPresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public InputtingEnergyItemTriggerData data;
      public IInputQTEService inputQTEService;
      public IInputProgressService inputProgressService;
      public IPlayerGetter playerGetter;
      public TableContainer table;

      public Model(
        InputtingEnergyItemTriggerData data,
        IInputQTEService inputQTEService,
        IInputProgressService inputProgressService,
        IPlayerGetter playerGetter,
        TableContainer table)
      {
        this.data = data;
        this.inputQTEService = inputQTEService;
        this.inputProgressService = inputProgressService;
        this.playerGetter = playerGetter;
        this.table = table;
      }
    }

    private readonly Model model;
    private readonly InputtingEnergyItemTriggerView view;

    private bool isEnable;

    public InputtingEnergyItemTriggerPresenter(Model model, InputtingEnergyItemTriggerView view)
    {
      this.model = model;
      this.view = view;

      view.SubscribeOnEnter(OnEnter);
    }

    public void Enable(bool enable)
    {
      if (isEnable == enable)
        return;

      isEnable = enable;
    }

    public void Restart()
    {
      Enable(true);
      view.gameObject.SetActive(true);
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (isEnable == false)
        return;
      if (collider2D.CompareTag(Tag.Player) == false)
        return;

      var playerType = collider2D
              .GetComponentInParent<IPlayerView>()
              .GetPlayerType();

      var inputtingPlayerPresenter = model
        .playerGetter
        .GetPlayer(playerType);
      var inputtingPlayerReactionContrller = inputtingPlayerPresenter
        .GetReactionController();

      var restorePlayerPresenter = model
        .playerGetter
        .GetPlayer(playerType.ParseOpposite());
      var restoreReactionController = restorePlayerPresenter
        .GetReactionController();

      switch (view.Input)
      {
        case InputtingEnergyItemTriggerView.EnergyItemInput.QTE:
          {
            var keyCodeData = model
        .table
        .GetPlayerModelSO(playerType)
        .Movement
        .KeyCodeData;

            PlayQTE(inputtingPlayerReactionContrller, restoreReactionController, keyCodeData);
          }
          break;

        case InputtingEnergyItemTriggerView.EnergyItemInput.Progress:
          {
            var keyCodeData = model
        .table
        .GetPlayerModelSO(playerType)
        .Movement
        .KeyCodeData;

            PlayProgress(inputtingPlayerReactionContrller, restoreReactionController, keyCodeData);
          }
          break;
      }
    }

    private void PlayQTE(
      IPlayerReactionController inputtingReactionController,
      IPlayerReactionController restoreReactionController,
      CharacterMoveKeyCodeData keyCodeData)
    {
      inputtingReactionController.SetInputting(true);
      model.inputQTEService.Play(
        model.data.QTEData,
        keyCodeData,
        view.transform.position,
        onSuccess: () =>
        {
          RestorePlayer(restoreReactionController);
          view.gameObject.SetActive(false);
          inputtingReactionController.SetInputting(false);
        },
        () => OnFail(inputtingReactionController));
    }

    private void PlayProgress(
      IPlayerReactionController inputtingReactionController,
      IPlayerReactionController restoreReactionController,
      CharacterMoveKeyCodeData keyCodeData)
    {
      inputtingReactionController.SetInputting(true);
      model.inputProgressService.Play(
        model.data.InputProgressData,
        keyCodeData,
        view.transform.position,
        null,
        () =>
        {
          RestorePlayer(restoreReactionController);
          view.gameObject.SetActive(false);
          inputtingReactionController.SetInputting(false);
        },
        () => OnFail(inputtingReactionController));
    }
    
    private void OnFail(IPlayerReactionController inputtingReactionController)
    {
      inputtingReactionController.SetInputting(false);
      view.gameObject.SetActive(false);
      Enable(false);
    }

    private void RestorePlayer(IPlayerReactionController restoreReactionController)
      => restoreReactionController.RestoreEnergy(model.data.RestoreValue);
  }
}
