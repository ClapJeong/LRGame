using Cysharp.Threading.Tasks;
using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace LR.UI.GameScene
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

    private readonly IGameObjectController content;
    private readonly ICanvasGroupView backGroundCanvasGroup;
    private readonly ILocalizeStringView restartText;

    private readonly InputAction restartInputAction;

    public UIStageFailPresenter(Model model, UIStageFailViewContainer stageFailViewContainer)
    {
      this.model = model;
      this.stageFailViewContainer = stageFailViewContainer;

      this.content = stageFailViewContainer;
      this.backGroundCanvasGroup = stageFailViewContainer.failBackgroundView;
      this.restartText = stageFailViewContainer.failTextView;

      var inputActionFactory = GlobalManager.instance.FactoryManager.InputActionFactory;
      restartInputAction = inputActionFactory.Get(model.restartInputActionPath, model.onRestartStage, InputActionFactory.InputActionPhaseType.Performed);

      backGroundCanvasGroup.SetAlpha(0.0f);
      restartText.SetArgument(new() { model.restartInputActionPath });
    }

    public UniTask ShowAsync(bool isImmediately = false)
    {
      throw new NotImplementedException();
    }

    public UniTask HideAsync(bool isImmediately = false)
    {
      throw new NotImplementedException();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public UIVisibleState GetVisibleState()
    {
      throw new NotImplementedException();
    }

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