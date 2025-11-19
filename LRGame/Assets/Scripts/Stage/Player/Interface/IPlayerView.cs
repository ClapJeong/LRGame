using UnityEngine;

public interface IPlayerView : IGameObjectView, IPositionView
{
  public void SetSO(PlayerModelSO so);

  public PlayerType GetPlayerType();

  public void AddDirection(Vector3 direction);

  public void RemoveDirection(Vector3 direction);
}
