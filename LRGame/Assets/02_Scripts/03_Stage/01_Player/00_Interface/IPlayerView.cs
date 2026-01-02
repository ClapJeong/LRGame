using UnityEngine;

namespace LR.Stage.Player
{
  public interface IPlayerView :
  IRigidbodyController
  {
    public PlayerType GetPlayerType();
    public GameObject GameObject { get; }
    public Transform Transform { get; }
  }
}