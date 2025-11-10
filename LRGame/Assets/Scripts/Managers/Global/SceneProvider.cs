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
  readonly private Dictionary<SceneType, AsyncOperationHandle<SceneInstance>> cachedHandled = new();
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


  private AsyncOperationHandle<SceneInstance> LoadSceneHandle(SceneType sceneType)
  {
    if (cachedHandled.TryGetValue(sceneType, out var existHandle) == false)
    {
      var sceneKey = GetSceneKey(sceneType);
      existHandle = Addressables.LoadSceneAsync(sceneKey, LoadSceneMode.Single, false);
    }

    return existHandle;
  }

  private string GetSceneKey(SceneType sceneType)
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    return sceneType switch
    {
      SceneType.Initialize => throw new NotImplementedException(),
      SceneType.Preloading => table.Path.Scene + table.SceneName.Preloading,
      SceneType.Lobby => table.Path.Scene + table.SceneName.Lobby,
      SceneType.Game => table.Path.Scene + table.SceneName.Game,
      _ => throw new NotImplementedException()
    };
  }
}
