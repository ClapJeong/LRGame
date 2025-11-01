using Cysharp.Threading.Tasks;
using UnityEngine;

public enum StageObjectType
{
  Player,
  Trigger,
}

public interface IStageObjectSetupService<T>
{
  public UniTask SetupAsync();

  public void Release();
}
