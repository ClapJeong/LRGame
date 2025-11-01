using UnityEngine;

public class ResourceManager : MonoBehaviour
{
    public static ResourceManager Instance;

  private void Awake()
  {
    if (Instance != null)
      Destroy(this);

    Instance = this;
  }
}
