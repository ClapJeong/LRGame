using Cysharp.Threading.Tasks;
using System;
using System.Threading;
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
      public float showDuration;
      public float hideDuration;
      public string beginInputActionPath;
      public UnityAction onBeginStage;

      public Model(string beginInputActionPath,UnityAction onBeginStage,float showDuration,float hideDuration)
      {
        this.beginInputActionPath = beginInputActionPath;
        this.onBeginStage = onBeginStage;
        this.showDuration = showDuration;
        this.hideDuration = hideDuration;
      }
    }

    private UIVisibleState visibleState = UIVisibleState.None;

    private readonly Model model;
    private readonly UIStageBeginViewContainer viewContainer;

    private readonly ICanvasGroupTweenView canvasGroup;
    private readonly ILocalizeStringView beginGuideText;

    private InputAction beginInputAction;

    public UIStageBeginPresenter(Model model,UIStageBeginViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      this.canvasGroup = viewContainer.canvasGroupView;
      this.beginGuideText = viewContainer.textView;

      beginGuideText.SetArgument(new() { model.beginInputActionPath });
      canvasGroup.DoFadeAsync(1.0f, 0.0f).Forget();

      CreateBeginInputAction();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      GlobalManager.instance.FactoryManager.InputActionFactory.Release(beginInputAction);
    }

    public UIVisibleState GetVisibleState()
      => visibleState;

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      beginInputAction.Disable();
      visibleState = UIVisibleState.Hiding;
      await canvasGroup.DoFadeAsync(0.0f,model.hideDuration, token);
      visibleState = UIVisibleState.Hided;
    }


    public async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showing;
      await canvasGroup.DoFadeAsync(1.0f,0.5f,token);
      visibleState = UIVisibleState.Showed;
      beginInputAction.Enable();
    }

    private void CreateBeginInputAction()
    {
      var inputActionFactory = GlobalManager.instance.FactoryManager.InputActionFactory;
      beginInputAction = inputActionFactory.Get(model.beginInputActionPath, () => model.onBeginStage?.Invoke(), InputActionFactory.InputActionPhaseType.Performed);
    }
  }
}