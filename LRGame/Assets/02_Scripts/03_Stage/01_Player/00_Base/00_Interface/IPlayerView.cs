using UnityEngine;
using LR.Stage.Player.Enum;

namespace LR.Stage.Player
{
  public interface IPlayerView
  {
    public PlayerType GetPlayerType();
    public GameObject GameObject { get; }
    public Transform Transform { get; }
  }
}