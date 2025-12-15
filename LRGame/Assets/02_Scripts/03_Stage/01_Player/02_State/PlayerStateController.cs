using System.Collections.Generic;

namespace LR.Stage.Player
{
  public class PlayerStateController : IPlayerStateController
  {
    private readonly Dictionary<PlayerStateType, IPlayerState> states = new();
    private PlayerStateType currentKey = PlayerStateType.None;
    private PlayerStateType previousKey = PlayerStateType.None;

    public void AddState(PlayerStateType type, IPlayerState state)
      => states[type] = state;

    public void RemoveState(PlayerStateType type, IPlayerState state)
    {
      if (states.ContainsKey(type))
        states.Remove(type);
    }

    public void ChangeState(PlayerStateType type)
    {
      if(states.TryGetValue(previousKey, out var previousState)) 
        previousState.OnExit();

      previousKey = currentKey;
      currentKey = type;

      if(states.TryGetValue(type, out var currentState))
        currentState.OnEnter();
    }

    public void UndoState()
    {
      ChangeState(previousKey);      
    }

    public void FixedUpdate()
    {
      if(states.TryGetValue(currentKey, out var currentState))
        currentState.FixedUpdate();
    }

    public PlayerStateType GetCurrentState()
      => currentKey;

    public void Dispose()
    {

    }
  }
}