using UnityEngine;

namespace LR.Stage.Player
{
  public class BasePlayerView : MonoBehaviour, IPlayerView
  {
    [SerializeField] private new Rigidbody2D rigidbody;
    [SerializeField] private PlayerType playerType;
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
      => rigidbody.linearVelocity = velocity;

    public void AddForce(Vector3 force, ForceMode2D forceMode = ForceMode2D.Force)
      => rigidbody.AddForce(force, forceMode);

    public Vector3 GetLinearVelocity()
      => rigidbody.linearVelocity;
    #endregion
  }
}