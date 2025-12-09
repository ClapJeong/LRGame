using UnityEngine;

public interface IPlayerView :
  IRigidbodyController,
  IGameObjectView, 
  IPositionView,   
  ISpriteRendererView
{
  public PlayerType GetPlayerType();
}
