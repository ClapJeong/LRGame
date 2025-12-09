using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine.Events;

public interface ISceneProvider
{
  public UniTask LoadSceneAsync(
    SceneType sceneType, 
    CancellationToken token = default,
    UnityAction<float> onProgress = null, 
    UnityAction onComplete = null,
    Func<UniTask> waitUntilLoad = null);

  public UniTask ReloadCurrentSceneAsync(
    CancellationToken token = default,
    UnityAction<float> onProgress = null,
    UnityAction onComplete = null,
    Func<UniTask> waitUntilLoad = null); 
}
