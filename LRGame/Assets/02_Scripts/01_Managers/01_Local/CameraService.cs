using UnityEngine;

public class CameraService : MonoBehaviour, ICameraService
{
  [SerializeField] private Camera mainCamera;

  public void SetSize(float size)
    => mainCamera.orthographicSize = size;
}