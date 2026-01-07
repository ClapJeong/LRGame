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
      public IInputProgressService inputProgressService;
      public IPlayerGetter playerGetter;
      public TableContainer table;

      public Model(RightEnergyItemTriggerData data, IInputProgressService inputProgressService, IPlayerGetter playerGetter, TableContainer table)
      {
        this.data = data;
        this.inputProgressService = inputProgressService;
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

      enterPlayerReactionController.SetInputting(true);
      model.inputProgressService.Play(
        model.data.InputProgressData,
        enterPlayerKeyCodeData,
        view.transform.position,
        OnChargingProgress,
        () =>
        {
          OnChargerComplete(targetPlayerPresenter);
          Enable(false);
          view.gameObject.SetActive(false);
          enterPlayerReactionController.SetInputting(false);
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
    }
  }
}
