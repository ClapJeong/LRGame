using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace LR.UI.GameScene
{
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

    private readonly UIStageBeginPresenter beginPresenter;
    private readonly UIStageFailPresenter failPresenter;    

    public UIGameFirstPresenter(Model model, UIGameFirstViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      this.beginPresenter = CreateBeginPresenter();
      this.failPresenter = CreateFailPresenter();

      beginPresenter.ShowAsync(true).Forget();
      failPresenter.HideAsync(true).Forget();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      if (viewContainer)
        GameObject.Destroy(viewContainer);
    }

    public UIVisibleState GetVisibleState()
      => UIVisibleState.Showed;

    public UniTask HideAsync(bool isImmediately = false)
      => throw new NotImplementedException();

    public void SetVisibleState(UIVisibleState visibleState)
      => throw new NotImplementedException();

    public UniTask ShowAsync(bool isImmediately = false)
      => throw new NotImplementedException();

    public void OnGameFailed()
    {
      failPresenter.ShowAsync().Forget();
    }

    private UIStageBeginPresenter CreateBeginPresenter()
    {
      var model = new UIStageBeginPresenter.Model(this.model.beginInputActionPath, this.model.onBeginStage);
      var beginView = viewContainer.beginViewContainer;
      IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
      presenterFactory.Register(() => new UIStageBeginPresenter(model, beginView));
      return presenterFactory.Create<UIStageBeginPresenter>();
    }

    private UIStageFailPresenter CreateFailPresenter()
    {
      var model = new UIStageFailPresenter.Model(0.8f, 0.4f, this.model.restartInputActionPath,this.model.onRestartStage);
      var failView = viewContainer.failViewContainer;
      IUIPresenterFactory presenterFactory = GlobalManager.instance.UIManager;
      presenterFactory.Register(() => new UIStageFailPresenter(model, failView));
      return presenterFactory.Create<UIStageFailPresenter>();
    }

    private void OnBeginStage()
    {
      beginPresenter.HideAsync().Forget();
      model.onBeginStage?.Invoke();
    }

    private void OnRestartStage()
    {
      failPresenter.HideAsync().Forget();
      model.onRestartStage?.Invoke();
    }
  }
}