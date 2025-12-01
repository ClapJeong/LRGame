using Cysharp.Threading.Tasks;
using LR.UI;
using LR.UI.Indicator;
using System;
using UnityEngine;

public interface IUIIndicatorService
{
  public UniTask<IUIIndicatorPresenter> GetNewAsync(Transform root, IRectView beginTarget);

  public IUIIndicatorPresenter GetTopIndicator();

  public bool TryGetTopIndicator(out IUIIndicatorPresenter current);

  public IDisposable ReleaseIndicatorOnDestroy(IUIIndicatorPresenter indicator, GameObject target);

  public void ReleaseTopIndicator();

  public bool IsTopIndicatorIsThis(IUIIndicatorPresenter target);
}