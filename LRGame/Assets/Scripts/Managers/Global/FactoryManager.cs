using UnityEngine;

public class FactoryManager
{
  private InputActionFactory inputActionFactory;
  public InputActionFactory InputActionFactory => inputActionFactory; 

  public void Initialize()
  {
    CreateFactoreis();
  }

  private void CreateFactoreis()
  {
    inputActionFactory = new InputActionFactory();
  }
}
