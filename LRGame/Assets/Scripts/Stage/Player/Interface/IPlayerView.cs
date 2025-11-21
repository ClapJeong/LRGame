using UnityEngine;

public interface IPlayerView : IGameObjectView, IPositionView, IRigidbodyController
{
  public PlayerType GetPlayerType();
}
