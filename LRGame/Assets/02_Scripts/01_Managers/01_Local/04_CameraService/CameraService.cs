using UnityEngine;

public class CameraService : MonoBehaviour, ICameraService
{
  [SerializeField] private Camera mainCamera;

  public Vector2 GetScreenPosition(Vector3 worldPosition)
    => mainCamera.WorldToScreenPoint(worldPosition);

  public void SetSize(float size)
    => mainCamera.orthographicSize = size;
}