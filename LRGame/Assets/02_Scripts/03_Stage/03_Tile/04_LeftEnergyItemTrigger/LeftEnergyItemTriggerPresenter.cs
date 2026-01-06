using LR.Stage.Player;
using LR.Table.TriggerTile;
using System;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class LeftEnergyItemTriggerPresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public LeftEnergyItemTriggerData data;
      public IInputQTEService inputQTEService;
      public IPlayerGetter playerGetter;
      public TableContainer table;

      public Model(LeftEnergyItemTriggerData data, IInputQTEService inputQTEService, IPlayerGetter playerGetter, TableContainer table)
      {
        this.data = data;
        this.inputQTEService = inputQTEService;
        this.playerGetter = playerGetter;
        this.table = table;
      }
    }

    private readonly Model model;
    private readonly LeftEnergyItemTriggerView view;

    private bool isEnable;

    public LeftEnergyItemTriggerPresenter(Model model, LeftEnergyItemTriggerView view)
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

      Enable(false);

      var enterPlayerType = collider2D.GetComponent<IPlayerView>().GetPlayerType();
      var enterPlayerKeyCodeData = model
        .table
        .GetPlayerModelSO(enterPlayerType)
        .Movement
        .KeyCodeData;
      var enterPlayerReactionController = model
              .playerGetter
              .GetPlayer(enterPlayerType)
              .GetReactionController();

      var targetPlayerPresenter = model
        .playerGetter
        .GetPlayer(enterPlayerType.ParseOpposite());

      enterPlayerReactionController.SetCharging(true);
      model.inputQTEService.Play(
        model.data.QTEData.UIType,
        model.data.QTEData,
        enterPlayerKeyCodeData,        
        view.transform.position,
        onSuccess: () =>
        {
          OnChargerComplete(targetPlayerPresenter);
          enterPlayerReactionController.SetCharging(false);          
        },
        onFail: () =>
        {          
          enterPlayerReactionController.SetCharging(false);          
        });
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
