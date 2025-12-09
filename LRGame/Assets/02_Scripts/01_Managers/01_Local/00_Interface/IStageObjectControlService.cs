using UnityEngine;

public interface IStageObjectControlService<T> where T: IStageObjectController
{
  public void EnableAll(bool isEnable);

  public void RestartAll();
}
