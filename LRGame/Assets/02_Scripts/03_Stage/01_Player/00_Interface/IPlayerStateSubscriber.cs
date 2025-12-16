using UnityEngine.Events;

namespace LR.Stage.Player
{
  public interface IPlayerStateSubscriber
  {
    public void SubscribeOnEnter(PlayerStateType playerState, UnityAction onEnter);

    public void UnsubscribeOnEnter(PlayerStateType playerState, UnityAction onEnter);

    public void SubscribeOnExit(PlayerStateType playerState, UnityAction onExit);

    public void UnsubscribeOnExit(PlayerStateType playerState, UnityAction onExit);
  }
}