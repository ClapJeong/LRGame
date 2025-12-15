using LR.Stage.Player;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class EnergyChargerTriggerPresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public IPlayerGetter playerGetter;

      public Model(IPlayerGetter playerGetter)
      {
        this.playerGetter = playerGetter;
      }
    }

    private readonly Model model;
    private readonly EnergyChargerTriggerView view;

    public EnergyChargerTriggerPresenter(Model model, EnergyChargerTriggerView view)
    {
      this.model = model;
      this.view = view;

      view.SubscribeOnEnter(OnEnter);
      view.SubscribeOnExit(OnExit);
    }

    public void Enable(bool enable)
    {
      view.gameObject.SetActive(enable);
    }

    public void Restart()
    {
      view.gameObject.SetActive(true);
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (collider2D.CompareTag("Player") == false)
        return;
      
      var playerType = collider2D.GetComponent<IPlayerView>().GetPlayerType();
      model
        .playerGetter
        .GetPlayer(playerType)
        .GetReactionController()
        .SetCharging(true);
    }

    private void OnExit(Collider2D collider2D)
    {
      if (collider2D.CompareTag("Player") == false)
        return;

      var playerType = collider2D.GetComponent<IPlayerView>().GetPlayerType();
      model
        .playerGetter
        .GetPlayer(playerType)
        .GetReactionController()
        .SetCharging(false);
    }
  }
}