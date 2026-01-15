using UnityEngine;
using LR.Stage.Player.Enum;

namespace LR.Stage.Player
{
  public class BasePlayerView : MonoBehaviour, IPlayerView
  {
    [SerializeField] private PlayerType playerType;

    [field: SerializeField] public Animator Animator {  get; private set; }
    [field: SerializeField] public Rigidbody2D Rigidbody2D { get; private set; }    
    [field: SerializeField] public SpriteRenderer SpriteRenderer { get; private set; }

    public GameObject GameObject
      => gameObject;

    public Transform Transform
      => transform;

    #region IPlayerView
    public PlayerType GetPlayerType()
      => playerType;
    #endregion

    #region IRigidbodyController
    public void SetLinearVelocity(Vector3 velocity)
      => Rigidbody2D.linearVelocity = velocity;

    public void AddForce(Vector3 force, ForceMode2D forceMode = ForceMode2D.Force)
      => Rigidbody2D.AddForce(force, forceMode);

    public Vector3 GetLinearVelocity()
      => Rigidbody2D.linearVelocity;
    #endregion
  }
}