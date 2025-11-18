using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BasePlayerView : MonoBehaviour, IPlayerView
{
  [SerializeField] private new Rigidbody2D rigidbody;
  [SerializeField] private PlayerType playerType;

  private PlayerModelSO so;
  
  private Vector3 inputDirection;

  private void FixedUpdate()
  {
    if (so == null)
      return;

    ApplyAcceleration();
  }

  private void ApplyAcceleration()
  {
    Vector3 currentVel = rigidbody.linearVelocity;
    Vector3 desiredVel = inputDirection.normalized * so.Movement.MaxSpeed;

    bool hasInput = inputDirection.sqrMagnitude > 0.01f;

    if (hasInput)
    {
      // 입력이 있을 때: currentVel → desiredVel 로 가속
      currentVel = Vector3.MoveTowards(
          currentVel,
          desiredVel,
          so.Movement.Acceleration * Time.fixedDeltaTime
      );
    }
    else
    {
      // 입력 없을 때: currentVel → 0 으로 감속
      currentVel = Vector3.MoveTowards(
          currentVel,
          Vector3.zero,
          so.Movement.Decceleration * Time.fixedDeltaTime
      );
    }

    rigidbody.linearVelocity = currentVel;
  }

  public void SetSO(PlayerModelSO so)
    =>this.so = so;

  public void AddDirection(Vector3 direction)
    => inputDirection += direction;

  public void RemoveDirection(Vector3 direction)
    => inputDirection -= direction;

  public void SetActive(bool isActive)
    =>gameObject.SetActive(isActive);

  public void SetLocalPosition(Vector3 position)
    =>transform.localPosition = position;

  public void SetRoot(Transform root)
    => transform.SetParent(root);

  public void SetWorldPosition(Vector3 worldPosition)
    => transform.position = worldPosition;

  public PlayerType GetPlayerType()
    => playerType;

  public void AddWorldPosition(Vector3 value)
    => transform.position += value;

  public void AddLocalPosition(Vector3 value)
    => transform.localPosition += value;
}
