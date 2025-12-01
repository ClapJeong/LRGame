using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIChapterButtonPresenter : IUIPresenter
  {
    public class Model
    {
      이거도해야하는데스우
    }

    private readonly Model model;
    private readonly UIChapterButtonViewContainer viewContainer;

    public UIChapterButtonPresenter(Model model, UIChapterButtonViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (viewContainer)
        viewContainer.gameObjectView.DestroyGameObject();
    }
    

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }
    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public UIVisibleState GetVisibleState()
    {
      throw new NotImplementedException();
    }
  }
}