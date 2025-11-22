using UnityEngine;

public class BaseGameObjectView : MonoBehaviour, IGameObjectView
{
  public void SetActive(bool active)
    =>gameObject.SetActive(active);

  public void SetRoot(Transform root)
    =>transform.SetParent(root);
}