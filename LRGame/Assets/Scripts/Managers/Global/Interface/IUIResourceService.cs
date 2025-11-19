using Cysharp.Threading.Tasks;
using UnityEngine;

public interface IUIResourceService
{
  public UniTask<T> CreateViewAsync<T>(string viewKey, UIRootType createRoot) where T : UnityEngine.Object;

  public void ReleaseView(GameObject view, bool releaseHandle = false);
}
