using Cysharp.Threading.Tasks;
using LR.UI;
using LR.UI.Indicator;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class UIIndicatorService : IUIIndicatorService
{
  private readonly Stack<IUIIndicatorPresenter> enableIndicators = new();
  private readonly Stack<IUIIndicatorPresenter> disabledIndicators = new();
  private readonly Transform disableRoot;

  private readonly string indicatorKey;
  private readonly IResourceManager resourceManager;

  public UIIndicatorService(IResourceManager resourceManager, Transform disableRoot)
  {
    this.resourceManager = resourceManager;
    this.disableRoot = disableRoot;
    var table = GlobalManager.instance.Table.AddressableKeySO;
    indicatorKey = table.Path.Ui + table.UIName.Indicator;
  }


  public void AttachCurrentWithGameObject(GameObject target)
  {
    target
            .OnDestroyAsObservable()
            .Subscribe(_ => ReleaseTopIndicator());
  }

  public IUIIndicatorPresenter GetTopIndicator()
    => enableIndicators.Peek();

  public bool TryGetTopIndicator(out IUIIndicatorPresenter current)
    => enableIndicators.TryPeek(out current) && current != null;


  public async UniTask<IUIIndicatorPresenter> GetNewAsync(Transform root, IRectView beginTarget)
  {
    if(disabledIndicators.TryPeek(out var topIndicator))
    {
      topIndicator.ReInitialize(root, beginTarget);
      return topIndicator;
    }
    else
    {
      var newIndicator = await CreateAsync(root, beginTarget);
      enableIndicators.Push(newIndicator);
      return newIndicator;
    }
  }

  public void ReleaseTopIndicator()
  {
    var disabledIndicator = enableIndicators.Pop();
    disabledIndicator.Disable(disableRoot);
    disabledIndicators.Push(disabledIndicator);
  }

  private async UniTask<IUIIndicatorPresenter> CreateAsync(Transform root, IRectView beginTarget)
  {
    var baseView = await resourceManager.CreateAssetAsync<BaseUIIndicatorView>(indicatorKey, root);
    var basePresenter = new BaseUIIndicatorPresenter(root, beginTarget, baseView);
    basePresenter.AttachOnDestroy(root.gameObject);
    return basePresenter;
  }
}