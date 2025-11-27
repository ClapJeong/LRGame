using Cysharp.Threading.Tasks;
using LR.UI;
using LR.UI.Indicator;
using UnityEngine;

public interface IUIIndicatorService
{
  public UniTask<IUIIndicatorPresenter> CreateAsync(Transform root, IRectView beginTarget);

  public IUIIndicatorPresenter GetCurrent();

  public bool TryGetCurrent(out IUIIndicatorPresenter current);

  public void AttachCurrentWithGameObject(GameObject target);

  public void Push(IUIIndicatorPresenter presenter);

  public IUIIndicatorPresenter Pop();

  public void DestroyCurrent();
}