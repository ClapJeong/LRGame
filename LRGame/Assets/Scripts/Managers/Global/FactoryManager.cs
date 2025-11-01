using UnityEngine;

public class FactoryManager : MonoBehaviour
{
    public static FactoryManager Instance;

  private InputActionFactory inputActionFactory;
  public InputActionFactory InputActionFactory => inputActionFactory;

  private void Awake()
  {
    if (Instance != null)
      Destroy(gameObject);

    Instance = this;
    CreateFactoreis();
  }

  private void CreateFactoreis()
  {
    inputActionFactory = new InputActionFactory();
  }
}
