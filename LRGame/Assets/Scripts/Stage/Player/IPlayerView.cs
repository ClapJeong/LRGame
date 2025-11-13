using UnityEngine;

public interface IPlayerView : IGameObjectController, IPositionController
{
  public PlayerType GetPlayerType();

  public void AddForce(Vector3 force);

  public void RemoveForce(Vector3 force);
}
