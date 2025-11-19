using UnityEngine;

public class BasePositionView : MonoBehaviour, IPositionView
{
  public void AddLocalPosition(Vector3 value)
    => transform.localPosition += value;

  public void AddWorldPosition(Vector3 value)
    => transform.position += value;

  public void SetLocalPosition(Vector3 localPosition)
    =>transform.localPosition = localPosition;

  public void SetWorldPosition(Vector3 worldPosition)
    =>transform.position = worldPosition;
}