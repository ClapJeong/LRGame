using Cysharp.Threading.Tasks;
using LR.UI;
using LR.UI.Indicator;
using System;
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


  public IDisposable ReleaseIndicatorOnDestroy(IUIIndicatorPresenter indicator, GameObject target)
    => target
            .OnDestroyAsObservable()
            .Subscribe(_ =>
            {
              indicator.Disable(disableRoot);
              disabledIndicators.Push(indicator);
            });

  public IUIIndicatorPresenter GetTopIndicator()
    => enableIndicators.Peek();

  public bool TryGetTopIndicator(out IUIIndicatorPresenter current)
    => enableIndicators.TryPeek(out current) && current != null;


  public async UniTask<IUIIndicatorPresenter> GetNewAsync(Transform root, IRectView beginTarget)
  {
    if(disabledIndicators.TryPop(out var topIndicator))
    {
      enableIndicators.Push(topIndicator);
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

  public bool IsTopIndicatorIsThis(IUIIndicatorPresenter target)
    => TryGetTopIndicator(out var topIndicator) && topIndicator == target;

  private async UniTask<IUIIndicatorPresenter> CreateAsync(Transform root, IRectView beginTarget)
  {
    var baseView = await resourceManager.CreateAssetAsync<BaseUIIndicatorView>(indicatorKey, root);
    var basePresenter = new BaseUIIndicatorPresenter(root, beginTarget, baseView);
    return basePresenter;
  }
}