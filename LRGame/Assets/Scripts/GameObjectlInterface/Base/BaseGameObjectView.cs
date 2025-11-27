using UnityEngine;

public class BaseGameObjectView : MonoBehaviour, IGameObjectView
{
  public void DestroyGameObject()
    => Destroy(gameObject);

  public void SetActive(bool active)
    => gameObject.SetActive(active);

  public void SetRoot(Transform root)
    => transform.SetParent(root);
}