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

      enterPlayerReactionController.SetInputting(true);
      model.inputQTEService.Play(
        model.data.QTEData,
        enterPlayerKeyCodeData,        
        view.transform.position,
        onSuccess: () =>
        {
          OnChargerComplete(targetPlayerPresenter);
          view.gameObject.SetActive(false);
          enterPlayerReactionController.SetInputting(false);          
        },
        onFail: () =>
        {          
          enterPlayerReactionController.SetInputting(false);          
        });
    }

    private void OnChargerComplete(IPlayerPresenter targetPlayer)
    {
      targetPlayer
        .GetReactionController()
        .RestoreEnergy(model.data.RestoreValue);
    }
  }
}
