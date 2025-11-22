using UnityEngine;

public interface IGameObjectView
{
  public void SetActive(bool active);

  public void SetRoot(Transform root);
}
