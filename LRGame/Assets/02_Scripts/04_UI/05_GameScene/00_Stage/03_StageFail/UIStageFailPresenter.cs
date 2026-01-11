using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.GameScene.Stage
{
  public class UIStageFailPresenter : IUIPresenter
  {
    public class Model
    {
      public IUIIndicatorService indicatorService;
      public IStageStateHandler stageService;
      public ISceneProvider sceneProvider;
      public IUISelectedGameObjectService selectedGameObjectService;
      public IUIDepthService depthService;

      public Model(IUIIndicatorService indicatorService, IStageStateHandler stageService, ISceneProvider sceneProvider, IUISelectedGameObjectService selectedGameObjectService, IUIDepthService depthService)
      {
        this.indicatorService = indicatorService;
        this.stageService = stageService;
        this.sceneProvider = sceneProvider;
        this.selectedGameObjectService = selectedGameObjectService;
        this.depthService = depthService;
      }
    }

    private readonly Model model;
    private readonly UIStageFailView view;    

    private readonly SubscribeHandle subscribeHandle;
    private IUIIndicatorPresenter currentIndicator;

    public UIStageFailPresenter(Model model, UIStageFailView view)
    {
      this.model = model;
      this.view = view;

      view.RestartProgressSubmitSet.Subscribe(
        view.RestartProgressSubmitSet.InputDirection,
        onPerformed: null,
        onCanceled: null,
        onProgress: view.RestartProgressSubmitSet.FillImage.SetFillAmount,
        onComplete: OnRestart);

      view.QuitProgressSubmitSet.Subscribe(
              view.QuitProgressSubmitSet.InputDirection,
              onPerformed: null,
              onCanceled: null,
              onProgress: view.QuitProgressSubmitSet.FillImage.SetFillAmount,
              onComplete: OnQuit);

      subscribeHandle = new(
        onSubscribe: () =>
        {
          model.depthService.RaiseDepth(view.RestartProgressSubmitSet.RectTransform.gameObject);
          model.selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);
        },
        onUnsubscribe: () =>
        {
          if (currentIndicator != null)
            ReleaseIndicator();

          model.depthService.LowerDepth();
          model.selectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);          
        });
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await GetNewIndicatorAsync();
      subscribeHandle.Subscribe();
      model.depthService.SelectTopObject();
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmediately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    public void Dispose()
    {
      subscribeHandle.Dispose();

      if (view)
        view.DestroySelf();
    }

    private void OnSelectedGameObjectEnter(GameObject gameObject)
    {
      if (gameObject.TryGetComponent<Selectable>(out var selectable))
        currentIndicator.SetLeftInputGuide(selectable.navigation);

      if (gameObject.TryGetComponent<IUIProgressSubmitView>(out var progressSubmitView))
        currentIndicator.SetRightInputGuide(progressSubmitView);
    }

    private void OnRestart()
    {
      DeactivateAsync().Forget();
      model.stageService.RestartAsync().Forget();
    }

    private void OnQuit()
    {
      Dispose();
      model.sceneProvider.LoadSceneAsync(SceneType.Lobby).Forget();
    }

    private async UniTask GetNewIndicatorAsync()
    {
      currentIndicator = await model.indicatorService.GetNewAsync(view.IndicatorRoot, view.RestartProgressSubmitSet.RectTransform);
    }

    private void ReleaseIndicator()
    {
      model.indicatorService.ReleaseTopIndicator();
      currentIndicator = null;
    }
  }
}