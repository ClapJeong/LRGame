using Cysharp.Threading.Tasks;
using LR.UI.Loading;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class SceneProvider : ISceneProvider
{
  private readonly IResourceManager resourceManager;
  private readonly ICanvasProvider canvasProvider;
  private readonly string loadingUIViewPath;

  private SceneType currentScene = SceneType.Initialize;
  private AsyncOperationHandle<SceneInstance>? currentHandle;

  public SceneProvider(IResourceManager resourceManager, ICanvasProvider canvasProvider, AddressableKeySO addressableSO)
  {
    this.resourceManager = resourceManager;
    this.canvasProvider = canvasProvider;

    loadingUIViewPath = addressableSO.Path.UI + addressableSO.UIName.Loading;
  }

  public async UniTask LoadSceneAsync(
    SceneType sceneType,
    bool useUI = true,
    CancellationToken token = default,
    UnityAction<float> onProgress = null, 
    UnityAction onComplete = null, 
    Func<UniTask> waitUntilLoad = null)
  {
    UILoadingPresenter loadingPresenter = null;
    if(useUI)
    {
      var model = new UILoadingPresenter.Model();
      var view = await CreateLoadingUIViewAsync();
      loadingPresenter = new UILoadingPresenter(model, view);
    }    
    try
    {
      if(useUI)
        await loadingPresenter.ActivateAsync(false, token);
      if (currentHandle.HasValue && currentHandle.Value.IsValid())
      {
        await Addressables.UnloadSceneAsync(currentHandle.Value);
        currentHandle = null;
      }

      var handle = Addressables.LoadSceneAsync(
          GetSceneKey(sceneType),
          LoadSceneMode.Single,
          activateOnLoad: false
      );

      currentHandle = handle;

      while (!handle.IsDone)
      {
        token.ThrowIfCancellationRequested();
        onProgress?.Invoke(handle.PercentComplete);
        await UniTask.Yield();
      }

      await handle.Result.ActivateAsync();      
      
      currentScene = sceneType;
      onComplete?.Invoke();

      LocalManager localManager = null;
      foreach (var root in handle.Result.Scene.GetRootGameObjects())
      {
        localManager = root.GetComponentInChildren<LocalManager>(true);
        if (localManager != null)
        {
          await localManager.InitializeAsync();          
          break;
        }          
      }

      if (useUI)
        await loadingPresenter.DeactivateAsync();
      localManager?.Play();
    }
    catch (OperationCanceledException e) { Debug.Log(e); }
  }

  public async UniTask ReloadCurrentSceneAsync(
    bool useUI = true,
    CancellationToken token = default,    
    UnityAction<float> onProgress = null, 
    UnityAction onComplete = null, 
    Func<UniTask> waitUntilLoad = null)
  {
    await LoadSceneAsync(currentScene, useUI, token, onProgress, onComplete, waitUntilLoad);
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

  private async UniTask<UILoadingView> CreateLoadingUIViewAsync()
  {
    var canvasRoot = canvasProvider.GetCanvas(UIRootType.SceneLoading);    
    var view = await resourceManager.CreateAssetAsync<UILoadingView>(loadingUIViewPath, canvasRoot.transform);
    return view;
  }
}
