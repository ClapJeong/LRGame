using UnityEngine;

public interface IScaleController
{
  public void SetWorldScale(Vector3 scale);

  public void AddWorldScale(Vector3 value);

  public void SetLocalScale(Vector3 scale);

  public void AddLocalScale(Vector3 value);
}
