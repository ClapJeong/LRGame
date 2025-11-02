using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.InputSystem;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceLocations;

public class ResourceManager : IDisposable
{
  readonly private Dictionary<IResourceLocation, AsyncOperationHandle> loadHandles = new();
  readonly private List<AsyncOperationHandle> createdHandles = new();

  public async UniTask LoadAssetsAsync(string key)
  {
    var locations = await GetLocationsAsync(key);
    await LoadAssetsAsync(locations);
  }

  public async UniTask LoadAssetsAsync(AssetReference assetReference)
  {
    var locations = await GetLocationsAsync(assetReference);
    await LoadAssetsAsync(locations);
  }

  public async UniTask LoadAssetsAsync(IList<IResourceLocation> locations)
  {
    var handles = new List<AsyncOperationHandle>();
    foreach (var location in locations)
    {
      var loadHandle = await LoadAsync(location);
      handles.Add(loadHandle);
    }

    await Addressables.ResourceManager.CreateGenericGroupOperation(handles, true);
  }

  public async UniTask<AsyncOperationHandle> LoadAsync(IResourceLocation location)
  {
    var handle = Addressables.LoadAssetAsync<object>(location);
    await handle;
    loadHandles[location] = handle;
    return handle;
  }

  public async UniTask<T> CreateAssetAsync<T>(string key, Transform root = null) where T : MonoBehaviour
  {
    var results = await CreateAssetsAsync<T>(key, root);
    return results.First();
  }

  public async UniTask<T> CreateAssetAsync<T>(AssetReference assetReference, Transform root = null) where T : MonoBehaviour
  {
    var results = await CreateAssetsAsync<T>(assetReference, root);
    return results.First();
  }

  public async UniTask<List<T>> CreateAssetsAsync<T>(string key, Transform root = null) where T : MonoBehaviour
  {
    var locations = await GetLocationsAsync(key);
    return await CreateAssetsAsync<T>(locations, root);
  }

  public async UniTask<List<T>> CreateAssetsAsync<T>(AssetReference assetReference, Transform root = null) where T: MonoBehaviour
  {
    var locations = await GetLocationsAsync(assetReference);
    return await CreateAssetsAsync<T>(locations, root);
  }

  private async UniTask<List<T>> CreateAssetsAsync<T>(IList<IResourceLocation> locations, Transform root = null) where T:MonoBehaviour
  {
    var objects = new List<T>();
    foreach (var location in locations)
    {
      if (!loadHandles.TryGetValue(location, out var handle))
        handle = await LoadAsync(location);

      var createdGameObject = MonoBehaviour.Instantiate(handle.Result as GameObject, root);
      createdHandles.Add(handle);

      objects.Add(createdGameObject.GetComponent<T>());
    }

    return objects;
  }

  private async UniTask<IList<IResourceLocation>> GetLocationsAsync(string key)
  {
    var locationHandle = Addressables.LoadResourceLocationsAsync(key);
    await locationHandle;
    return locationHandle.Result;
  }

  private async UniTask<IList<IResourceLocation>> GetLocationsAsync(AssetReference assetReference)
  {
    var locationHandle = Addressables.LoadResourceLocationsAsync(assetReference);
    await locationHandle;
    return locationHandle.Result;
  }

  public void ReleaseAll()
  {
    foreach (var handle in loadHandles.Values)
      handle.Release();
    loadHandles.Clear();
  }

  public void Dispose()
  {
    ReleaseAll();
  }
}
