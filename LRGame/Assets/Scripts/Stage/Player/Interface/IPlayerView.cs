using UnityEngine;

public interface IPlayerView : IGameObjectView, IPositionView, IRigidbodyController, ISpriteRendererView
{
  public PlayerType GetPlayerType();
}
