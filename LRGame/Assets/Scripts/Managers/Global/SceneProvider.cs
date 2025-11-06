using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;


public class SceneProvider : MonoBehaviour, ISceneProvider
{
  [SerializeField] private AssetReference gameSceneReference;

  readonly private Dictionary<AssetReference, AsyncOperationHandle<SceneInstance>> cachedHandled = new();
  private SceneType currentScene;

  public async UniTask LoadSceneAsync(
    SceneType sceneType,
    CancellationToken token,
    UnityAction<float> onProgress = null, 
    UnityAction onComplete = null, Func<UniTask> 
    waitUntilLoad = null)
  {
    var handle = LoadSceneHandle(sceneType);
    try
    {
      while (!handle.IsDone)
      {
        token.ThrowIfCancellationRequested();

        onProgress?.Invoke(handle.PercentComplete);
        await UniTask.Yield(PlayerLoopTiming.Update);
      }
      onProgress?.Invoke(1.0f);

      if (waitUntilLoad != null)
        await waitUntilLoad.Invoke();

      currentScene = sceneType;
      await handle.Result.ActivateAsync();
    }
    catch (OperationCanceledException e) { Debug.Log(e); }
  }

  public async UniTask ReloadCurrentSceneAsync(
    CancellationToken token, 
    UnityAction<float> onProgress = null, 
    UnityAction onComplete = null, 
    Func<UniTask> waitUntilLoad = null)
  {
    await LoadSceneAsync(currentScene, token, onProgress, onComplete, waitUntilLoad);
  }

  private AssetReference ParseSceneReference(SceneType sceneType)
    => sceneType switch
    {
      SceneType.Initialize => throw new System.NotImplementedException(),
      SceneType.Game => gameSceneReference,
      _ => throw new System.NotImplementedException(),
    };

  private AsyncOperationHandle<SceneInstance> LoadSceneHandle(SceneType sceneType)
  {
    var sceneReference = ParseSceneReference(sceneType);
    if (cachedHandled.TryGetValue(sceneReference, out var existHandle)== false)    
    existHandle = Addressables.LoadSceneAsync(sceneReference, LoadSceneMode.Single, false);

    return existHandle;
  }
}
