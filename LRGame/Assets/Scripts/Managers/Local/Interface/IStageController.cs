using UnityEngine;

public interface IStageController
{
  public void Begin();

  public void Pause();

  public void Resume();

  public void Complete();

  public void Fail(StageFailType failType);  
}
