using LR.Stage.Player;
using LR.Table.TriggerTile;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class RightEnergyItemTriggerPresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public RightEnergyItemTriggerData data;
      public InputProgressService inputMashProgressService;
      public IPlayerGetter playerGetter;
      public TableContainer table;

      public Model(RightEnergyItemTriggerData data, InputProgressService inputMashProgressService, IPlayerGetter playerGetter, TableContainer table)
      {
        this.data = data;
        this.inputMashProgressService = inputMashProgressService;
        this.playerGetter = playerGetter;
        this.table = table;
      }
    }

    private readonly Model model;
    private readonly RightEnergyItmeTriggerView view;

    private bool isEnable;

    public RightEnergyItemTriggerPresenter(Model model, RightEnergyItmeTriggerView view)
    {
      this.model = model;
      this.view = view;

      view.SubscribeOnEnter(OnEnter);
    }

    public void Enable(bool enable)
    {
      if (isEnable == enable)
        return;

      view.gameObject.SetActive(enable);
      isEnable = enable;
    }

    public void Restart()
    {
      Enable(true);
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (isEnable == false)
        return;
      if (collider2D.CompareTag("Player") == false)
        return;

      var currentPlayerType = collider2D
              .GetComponent<IPlayerView>()
              .GetPlayerType();
      var currentPlayerKeyCodeData = model
        .table
        .GetPlayerModelSO(currentPlayerType)
        .Movement
        .KeyCodeData;

      var targetPlayerType = collider2D
              .GetComponent<IPlayerView>()
              .GetPlayerType()
              .ParseOpposite();
      var targetPlayerPresenter = model
        .playerGetter
        .GetPlayer(targetPlayerType);

      var playerReactionController = model
        .playerGetter
        .GetPlayer(currentPlayerType)
        .GetReactionController();

      playerReactionController.SetCharging(true);
      model.inputMashProgressService.Play(
        model.data.UIType,
        currentPlayerKeyCodeData,
        model.data.InputMashProgressData,
        view.transform.position,
        OnChargingProgress,
        () =>
        {
          OnChargerComplete(targetPlayerPresenter);
          playerReactionController.SetCharging(false);
          Enable(false);
        }, 
        null);
    }

    private void OnChargingProgress(float value)
    {

    }

    private void OnChargerComplete(IPlayerPresenter targetPlayer)
    {
      targetPlayer
        .GetEnergyController()
        .Restore(model.data.RestoreValue);

      Enable(false);
    }
  }
}
