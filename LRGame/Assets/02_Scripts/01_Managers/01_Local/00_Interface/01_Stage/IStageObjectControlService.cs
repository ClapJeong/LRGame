using UnityEngine;
using LR.Stage;

public interface IStageObjectControlService<T> where T: IStageObjectController
{
  public void EnableAll(bool isEnable);

  public void RestartAll();
}
