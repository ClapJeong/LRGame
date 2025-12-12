namespace LR.Stage.Player
{
  public interface IPlayerView :
  IRigidbodyController,
  IGameObjectView,
  IPositionView,
  ISpriteRendererView
  {
    public PlayerType GetPlayerType();
  }
}