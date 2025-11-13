using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BasePlayerView : MonoBehaviour, IPlayerView
{
  [SerializeField] private new Rigidbody2D rigidbody;
  [SerializeField] private PlayerType playerType;

  private Vector3 velocity = Vector3.zero;

  private void FixedUpdate()
  {
      rigidbody.linearVelocity = velocity;
  }

  public void AddForce(Vector3 force)
    => velocity +=force;

  public void RemoveForce(Vector3 force)
    => velocity-=force;

  public void SetActive(bool isActive)
    =>gameObject.SetActive(isActive);

  public void SetEuler(Vector3 euler)
    => transform.eulerAngles = euler;

  public void SetLocalPosition(Vector3 position)
    =>transform.localPosition = position;

  public void SetRoot(Transform root)
    => transform.SetParent(root);

  public void SetRotation(Quaternion rotation)
    => transform.rotation = rotation;

  public void SetScale(Vector3 scale)
    => transform.localScale = scale;

  public void SetWorldPosition(Vector3 worldPosition)
    => transform.position = worldPosition;

  public PlayerType GetPlayerType()
    => playerType;

  public void AddWorldPosition(Vector3 value)
    => transform.position += value;

  public void AddLocalPosition(Vector3 value)
    => transform.localPosition += value;
}
