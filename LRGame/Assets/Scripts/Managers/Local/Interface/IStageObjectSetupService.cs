using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public interface IStageObjectSetupService<T>
{
  public UniTask<List<T>> SetupAsync(object data, bool isEnableImmediately = false);

  public void Release();
}
