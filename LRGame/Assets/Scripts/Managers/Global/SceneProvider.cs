using Cysharp.Threading.Tasks;
using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public enum SceneType
{
  Initialize,
  Game,
}

public class SceneProvider : MonoBehaviour
{
  [SerializeField] private AssetReference gameSceneReference;

  public async UniTask LoadSceneAsync(SceneType sceneType, LoadSceneMode loadSceneMode = LoadSceneMode.Single, UnityAction<float> onProgress = null, Func<UniTask> waitUntilLoad=null)
  {
    var sceneRefernece = ParseSceneReference(sceneType);
    var handle = Addressables.LoadSceneAsync(sceneRefernece,loadSceneMode,false);
    while (!handle.IsDone)
    {
      onProgress?.Invoke(handle.PercentComplete);
      await UniTask.Yield(PlayerLoopTiming.Update);
    }
    onProgress?.Invoke(1.0f);

    if (waitUntilLoad != null)
      await waitUntilLoad.Invoke();

    await handle.Result.ActivateAsync();
  }

  private AssetReference ParseSceneReference(SceneType sceneType)
    => sceneType switch
    {
      SceneType.Initialize => throw new System.NotImplementedException(),
      SceneType.Game => gameSceneReference,
      _ => throw new System.NotImplementedException(),
    };
}
