using Cysharp.Threading.Tasks;
using UnityEngine;

public interface IUIResourceService
{
  public UniTask<IUIView> CreateViewAsync(string viewKey, UIRootType createRoot);

  public void Release(IUIView view);
}
