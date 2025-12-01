using Cysharp.Threading.Tasks;
using LR.UI;
using LR.UI.Indicator;
using UnityEngine;

public interface IUIIndicatorService
{
  public UniTask<IUIIndicatorPresenter> GetNewAsync(Transform root, IRectView beginTarget);

  public IUIIndicatorPresenter GetTopIndicator();

  public bool TryGetTopIndicator(out IUIIndicatorPresenter current);

  public void AttachCurrentWithGameObject(GameObject target);

  public void ReleaseTopIndicator();
}