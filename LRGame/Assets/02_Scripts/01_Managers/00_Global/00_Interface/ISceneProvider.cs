using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine.Events;

public interface ISceneProvider
{
  public UniTask LoadSceneAsync(
    SceneType sceneType,
    bool useUI = true,
    CancellationToken token = default,
    UnityAction<float> onProgress = null, 
    UnityAction onComplete = null,
    Func<UniTask> waitUntilLoad = null);

  public UniTask ReloadCurrentSceneAsync(
    bool useUI = true,
    CancellationToken token = default,
    UnityAction<float> onProgress = null,
    UnityAction onComplete = null,
    Func<UniTask> waitUntilLoad = null); 
}
