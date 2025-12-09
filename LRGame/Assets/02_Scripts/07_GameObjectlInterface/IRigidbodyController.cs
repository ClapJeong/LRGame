using UnityEngine;

public interface IRigidbodyController
{
  public Vector3 GetLinearVelocity();

  public void SetLinearVelocity(Vector3 velocity);

  public void AddForce(Vector3 force, ForceMode2D forceMode = ForceMode2D.Force);
}
