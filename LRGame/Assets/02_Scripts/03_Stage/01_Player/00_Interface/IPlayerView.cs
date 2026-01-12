using UnityEngine;

namespace LR.Stage.Player
{
  public interface IPlayerView
  {
    public PlayerType GetPlayerType();
    public GameObject GameObject { get; }
    public Transform Transform { get; }
  }
}