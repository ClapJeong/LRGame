using UnityEngine;

public class BaseScaleView : MonoBehaviour, IScaleView
{
  public void AddLocalScale(Vector3 value)
    => transform.localScale += value;

  public void SetLocalScale(Vector3 scale)
    =>transform.localScale = scale;
}