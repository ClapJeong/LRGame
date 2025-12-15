using LR.Stage.Player;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class EnergyItemTriggerPresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public EnergyItemData data;
      public IPlayerGetter playerGetter;

      public Model(EnergyItemData data, IPlayerGetter playerGetter)
      {
        this.data = data;
        this.playerGetter = playerGetter;
      }
    }

    private readonly Model model;
    private readonly EnergyItemTriggerView view;

    private bool isEnable = true;

    public EnergyItemTriggerPresenter(Model model, EnergyItemTriggerView view)
    {
      this.model = model;
      this.view = view;

      view.SubscribeOnEnter(OnEnter);
    }

    public void Enable(bool enable)
    {
      isEnable = enable;
    }

    public void Restart()
    {
      if (!isEnable)
        Activate();
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (collider2D.CompareTag("Player") == false)
        return;

      var playerType = collider2D.GetComponent<IPlayerView>().GetPlayerType();
      var energyController = model.playerGetter.GetPlayer(playerType.ParseOpposite()).GetEnergyController();
      if (energyController.IsFull())
        return;

      energyController.Restore(model.data.RestoreValue);

      Deactivate();
    }

    private void Activate()
    {
      isEnable = true;
      view.gameObject.SetActive(true);
    }

    private void Deactivate()
    {
      isEnable = false;
      view.gameObject.SetActive(false);
    }
  }
}