using UnityEngine;

public interface IUIDepthService
{
  public void SelectTopObject();

  public void RaiseDepth(GameObject newDepthFirstSelectingGameObject);

  public void LowerDepth();
}