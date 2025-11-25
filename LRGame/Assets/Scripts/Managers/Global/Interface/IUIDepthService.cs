using UnityEngine;

public interface IUIDepthService
{
  public void SelectTopObject();

  public void RaiseDepth(GameObject targetSelectingGameObject);

  public void LowerDepth();
}