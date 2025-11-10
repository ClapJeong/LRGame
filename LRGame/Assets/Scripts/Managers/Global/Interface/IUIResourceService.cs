using Cysharp.Threading.Tasks;
using UnityEngine;

public interface IUIResourceService
{
  public UniTask<GameObject> CreateViewAsync(string viewKey, UIRootType createRoot);

  public void ReleaseView(GameObject view, bool releaseHandle = false);
}
