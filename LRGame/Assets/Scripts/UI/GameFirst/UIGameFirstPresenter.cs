using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class UIGameFirstPresenter : IUIPresenter
{
  public class Model
  {
    public string beginInputActionPath;
    public string restartInputActionPath;

    public UnityAction onBeginStage;
    public UnityAction onRestartStage;

    public Model(string beginPath, string restartPath, UnityAction onBeginStage, UnityAction onRestartStage)
    {
      this.beginInputActionPath = beginPath;
      this.restartInputActionPath = restartPath;
      this.onBeginStage = onBeginStage;
      this.onRestartStage = onRestartStage;
    }
  }

  private readonly Model model;
  private readonly UIGameFirstViewContainer viewContainer;

  private readonly IRectController beginGuideRect;
  private readonly IRectController restartGuideRect;
  private readonly ILocalizeStringController beginGuideString;
  private readonly ILocalizeStringController restartGuideString;

  private readonly InputAction beginInputAction;
  private readonly InputAction restartInputAction;

  private readonly CompositeDisposable disposables;

  public UIGameFirstPresenter(Model model, UIGameFirstViewContainer viewContainer)
  {
    this.model = model;
    this.viewContainer = viewContainer;
    this.beginGuideRect = viewContainer.stageBeginView;
    this.beginGuideString = viewContainer.stageBeginView;
    this.restartGuideRect = viewContainer.stageRestartView;
    this.restartGuideString = viewContainer.stageRestartView;

    beginGuideString.SetArgument(new() { model.beginInputActionPath });
    restartGuideString.SetArgument(new() { model.restartInputActionPath });

    disposables = new CompositeDisposable();
    var inputActionFactory = GlobalManager.instance.FactoryManager.InputActionFactory;
    beginInputAction = inputActionFactory.Get(model.beginInputActionPath, OnBeginStage, InputActionFactory.InputActionPhaseType.Performed);
    restartInputAction = inputActionFactory.Get(model.restartInputActionPath, OnRestartStage, InputActionFactory.InputActionPhaseType.Performed);

    EnableBeginGuide();
    DisableRestartGuide();
  }

  public IDisposable AttachOnDestroy(GameObject target)
    => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

  public void Dispose()
  {
    if(viewContainer)
      GameObject.Destroy(viewContainer);
    var inputActionFactory = GlobalManager.instance.FactoryManager.InputActionFactory;
    inputActionFactory.Release(beginInputAction);
    inputActionFactory.Release(restartInputAction);
    disposables.Dispose();
  }

  public UIVisibleState GetVisibleState()
    => UIVisibleState.Showed;

  public UniTask HideAsync(bool isImmediately = false)
    => throw new NotImplementedException();

  public void SetVisibleState(UIVisibleState visibleState)
    => throw new NotImplementedException();

  public UniTask ShowAsync(bool isImmediately = false)
    => throw new NotImplementedException();

  public void EnableBeginGuide()
  {
    beginInputAction.Enable();
    beginGuideRect.SetActive(true);
  }

  public void DisableBeginGuide()
  {
    beginInputAction.Disable();
    beginGuideRect.SetActive(false);
  }

  public void EnableRestartGuide()
  {
    restartInputAction.Enable();
    restartGuideRect.SetActive(true);
  }

  public void DisableRestartGuide()
  {
    restartInputAction.Disable();
    restartGuideRect.SetActive(false);
  }

  private void OnBeginStage()
  {
    DisableBeginGuide();
    model.onBeginStage?.Invoke();
  }

  private void OnRestartStage()
  {
    DisableRestartGuide();
    model.onRestartStage?.Invoke();    
  }
}
