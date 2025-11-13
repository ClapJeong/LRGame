using UnityEngine;

public interface IPositionController
{
  public void SetWorldPosition(Vector3 worldPosition);

  public void AddWorldPosition(Vector3 value);

  public void SetLocalPosition(Vector3 localPosition);

  public void AddLocalPosition(Vector3 value);
}
