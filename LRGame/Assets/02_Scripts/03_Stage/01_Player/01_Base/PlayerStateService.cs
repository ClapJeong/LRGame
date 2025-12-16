using System.Collections.Generic;
using UnityEngine.Events;

namespace LR.Stage.Player
{
  public class PlayerStateService : IPlayerStateController, IPlayerStateSubscriber, IPlayerStateProvider
  {
    private readonly Dictionary<PlayerStateType, IPlayerState> states = new();
    private readonly Dictionary<PlayerStateType, UnityEvent> onEnterEvents = new();
    private readonly Dictionary<PlayerStateType, UnityEvent> onExitEvents = new();

    private PlayerStateType currentKey = PlayerStateType.None;
    private PlayerStateType previousKey = PlayerStateType.None;
    public void AddState(PlayerStateType type, IPlayerState state)
      => states[type] = state;

    public void RemoveState(PlayerStateType type, IPlayerState state)
    {
      if (states.ContainsKey(type))
        states.Remove(type);
    }

    #region IPlayerStateController
    public void ChangeState(PlayerStateType type)
    {
      if(states.TryGetValue(previousKey, out var previousState)) 
        previousState.OnExit();
      onExitEvents.TryInvoke(previousKey);

      previousKey = currentKey;
      currentKey = type;

      if(states.TryGetValue(currentKey, out var currentState))
        currentState.OnEnter();
      onEnterEvents.TryInvoke(currentKey);
    }

    public void FixedUpdate()
    {
      if(states.TryGetValue(currentKey, out var currentState))
        currentState.FixedUpdate();
    }
    #endregion

    #region IPlayerStateProvider
    public PlayerStateType GetCurrentState()
      => currentKey;
    #endregion

    #region IPlayerStateSubscriber
    public void SubscribeOnEnter(PlayerStateType playerState, UnityAction onEnter)
      => onEnterEvents.AddEvent(playerState, onEnter);

    public void UnsubscribeOnEnter(PlayerStateType playerState, UnityAction onEnter)
      => onEnterEvents.RemoveEvent(playerState, onEnter);

    public void SubscribeOnExit(PlayerStateType playerState, UnityAction onExit)
      => onExitEvents.AddEvent(playerState, onExit);

    public void UnsubscribeOnExit(PlayerStateType playerState, UnityAction onExit)
      => onExitEvents.RemoveEvent(playerState, onExit);
    #endregion

    public void Dispose()
    {

    }
  }
}