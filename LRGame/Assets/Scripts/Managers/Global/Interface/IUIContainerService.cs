using UnityEngine;

public interface IUIContainerService
{
  public T Get<T>(UIRootType rootType) where T : IUIPresenter;

  public bool TryGet<T>(UIRootType rootType, out T presenter) where T : IUIPresenter;
}
