using Cysharp.Threading.Tasks;
using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace LR.UI.GameScene
{
  public class UIStageBeginPresenter : IUIPresenter
  {
    public class Model
    {
      public string beginInputActionPath;
      public UnityAction onBeginStage;

      public Model(string  beginInputActionPath,UnityAction onBeginStage)
      {
        this.beginInputActionPath = beginInputActionPath;
        this.onBeginStage = onBeginStage;
      }
    }

    private UIVisibleState visibleState = UIVisibleState.None;

    private readonly Model model;
    private readonly UIStageBeginViewContainer viewContainer;

    private readonly ICanvasGroupView canvasGroup;
    private readonly ILocalizeStringView beginGuideText;

    private readonly InputAction beginInputAction;

    public UIStageBeginPresenter(Model model,UIStageBeginViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      this.canvasGroup = viewContainer.canvasGroupView;
      this.beginGuideText = viewContainer.textView;

      beginGuideText.SetArgument(new() { model.beginInputActionPath });
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      GlobalManager.instance.FactoryManager.InputActionFactory.Release(beginInputAction);
    }

    public UIVisibleState GetVisibleState()
    {
      throw new NotImplementedException();
    }

    public UniTask HideAsync(bool isImmediately = false)
    {
      throw new NotImplementedException();
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public UniTask ShowAsync(bool isImmediately = false)
    {
      throw new NotImplementedException();
    }
  }
}