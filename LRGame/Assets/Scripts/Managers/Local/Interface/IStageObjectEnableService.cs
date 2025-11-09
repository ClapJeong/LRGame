using UnityEngine;

public interface IStageObjectEnableService<T> where T: IStageObjectEnabler
{
  public void EnableAll(bool isEnable);
}
