using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace LR.UI.GameScene.Stage
{
  public class UIStageFailPresenter : IUIPresenter
  {
    public class Model
    {
      public float showDuration;
      public float hideDuration;
      public string restartInputActionPath;
      public UnityAction onRestartStage;

      public Model(float showDuration, float hideDuration, string restartInputActionPath,UnityAction onRestartStage)
      {
        this.showDuration = showDuration;
        this.hideDuration = hideDuration;
        this.restartInputActionPath = restartInputActionPath;
        this.onRestartStage = onRestartStage;
      }
    }

    private readonly Model model;
    private readonly UIStageFailViewContainer stageFailViewContainer;

    private readonly ICanvasGroupTweenView backGroundCanvasGroup;
    private readonly ILocalizeStringView restartText;

    private readonly InputAction restartInputAction;

    private UIVisibleState visibleState;

    public UIStageFailPresenter(Model model, UIStageFailViewContainer stageFailViewContainer)
    {
      this.model = model;
      this.stageFailViewContainer = stageFailViewContainer;

      this.backGroundCanvasGroup = stageFailViewContainer.failBackgroundView;
      this.restartText = stageFailViewContainer.failTextView;

      var inputActionFactory = GlobalManager.instance.FactoryManager.InputActionFactory;
      restartInputAction = inputActionFactory.Get(model.restartInputActionPath, model.onRestartStage, InputActionFactory.InputActionPhaseType.Performed);

      backGroundCanvasGroup.DoFadeAsync(0.0f,0.0f).Forget();
      restartText.SetArgument(new() { model.restartInputActionPath });
    }

    public async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showing;
      await backGroundCanvasGroup.DoFadeAsync(1.0f, model.showDuration, token);
      restartInputAction.Enable();
      visibleState = UIVisibleState.Showed;
    }

    public async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      restartInputAction.Disable();
      visibleState = UIVisibleState.Hiding;
      await backGroundCanvasGroup.DoFadeAsync(0.0f,model.hideDuration, token);
      visibleState = UIVisibleState.Hided;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public UIVisibleState GetVisibleState()
      => visibleState;

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
      GlobalManager.instance.FactoryManager.InputActionFactory.Release(restartInputAction);
    }
  }
}