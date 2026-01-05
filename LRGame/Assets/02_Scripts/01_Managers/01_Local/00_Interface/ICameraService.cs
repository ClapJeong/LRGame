using UnityEngine;

public interface ICameraService
{
  public void SetSize(float size);

  public Vector2 GetScreenPosition(Vector3 worldPosition);
}