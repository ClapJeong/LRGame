using UnityEngine;

public interface IStageController
{
  public void Complete();

  public void Fail(StageFailType failType);  
}
