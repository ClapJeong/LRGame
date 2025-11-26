using Cysharp.Threading.Tasks;
using LR.UI;
using LR.UI.Indicator;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class UIIndicatorService : IUIIndicatorService
{
  private readonly Stack<IUIIndicatorPresenter> indicators = new();
  private readonly string indicatorKey;
  private readonly IResourceManager resourceManager;

  public UIIndicatorService(IResourceManager resourceManager)
  {
    this.resourceManager = resourceManager;
    var table = GlobalManager.instance.Table.AddressableKeySO;
    indicatorKey = table.Path.Ui + table.UIName.Indicator;
  }

  public async UniTask<IUIIndicatorPresenter> CreateAsync(Transform root, IRectView beginTarget)
  {
    var baseView = await resourceManager.CreateAssetAsync<BaseUIIndicatorView>(indicatorKey, root);
    var basePresenter = new BaseUIIndicatorPresenter(root, beginTarget, baseView);
    basePresenter.AttachOnDestroy(root.gameObject);
    return basePresenter;
  }

  public void AttachCurrentWithGameObject(GameObject target)
  {
    if (GetCurrent() != null)
    {
      target
            .OnDestroyAsObservable()
            .Subscribe(_ => Pop());
    }
  }

  public IUIIndicatorPresenter GetCurrent()
    => indicators.Peek();

  public bool TryGetCurrent(out IUIIndicatorPresenter current)
    => indicators.TryPeek(out current) && current != null;

  public void Push(IUIIndicatorPresenter presenter)
    =>indicators.Push(presenter);

  public void Pop()
    => indicators.Pop();
}