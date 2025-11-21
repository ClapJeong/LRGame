using System.Collections.Generic;

public class PlayerStateController
{
  private Dictionary<PlayerStateType, IPlayerState> states = new();
  private IPlayerState currentState = null;

  public void AddState(PlayerStateType type, IPlayerState state)
    => states[type] = state;

  public void RemoveState(PlayerStateType type, IPlayerState state)
  {
    if(states.ContainsKey(type))
      states.Remove(type);
  }

  public void ChangeState(PlayerStateType type)
  {
    currentState?.OnExit();
    currentState = states[type];
    currentState.OnEnter();
  }

  public void FixedUpdate()
  {
    currentState.FixedUpdate();
  }
}