using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;

namespace LR.UI.GameScene.Stage
{
  public class UIStagePausePresenter : IUIPresenter
  {
    public class Model
    {
      public IUIIndicatorService indicatorService;
      public ISceneProvider sceneProvider;
      public IStageStateHandler stageService;
      public IUISelectedGameObjectService selectedGameObjectService;
      public IUIDepthService depthService;

      public Model(IUIIndicatorService indicatorService, ISceneProvider sceneProvider, IStageStateHandler stageService, IUISelectedGameObjectService selectedGameObjectService, IUIDepthService depthService)
      {
        this.indicatorService = indicatorService;
        this.sceneProvider = sceneProvider;
        this.stageService = stageService;
        this.selectedGameObjectService = selectedGameObjectService;
        this.depthService = depthService;
      }
    }

    private readonly Model model;
    private readonly UIStagePauseView view;    

    private readonly SubscribeHandle subscribeHandle;
    private IUIIndicatorPresenter currentIndicator;

    public UIStagePausePresenter(Model model, UIStagePauseView view)
    {
      this.view = view;
      this.model = model;

      view.ResumeProgressFillSubmit.Subscribe(
        view.ResumeProgressFillSubmit.InputDirection,
        onPerformed: null,
        onCanceled: null,
        onProgress: view.ResumeProgressFillSubmit.FillImage.SetFillAmount,
        onComplete: OnResume);

      view.RestartProgressFillSubmit.Subscribe(
        view.RestartProgressFillSubmit.InputDirection,
        onPerformed: null,
        onCanceled: null,
        onProgress: view.RestartProgressFillSubmit.FillImage.SetFillAmount,
        onComplete: OnRestart);

      view.QuitProgressFillSubmit.Subscribe(
        view.QuitProgressFillSubmit.InputDirection,
        onPerformed: null,
        onCanceled: null,
        onProgress: view.QuitProgressFillSubmit.FillImage.SetFillAmount,
        onComplete: OnQuit);

      subscribeHandle = new SubscribeHandle(
        () =>
        {
          model.selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);
          model.depthService.RaiseDepth(view.ResumeProgressFillSubmit.gameObject);
        },
        () =>
        {
          model.selectedGameObjectService.UnsubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);
          model.depthService.LowerDepth();
          if (currentIndicator != null)
            ReleaseIndicator();
        });
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      subscribeHandle.Dispose();
      if (view)
        view.DestroySelf();
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await GetNewIndicatorAsync();
      model.stageService.Pause();      
      subscribeHandle.Subscribe();
      model.depthService.SelectTopObject();
      await view.ShowAsync(isImmediately, token);
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {      
      subscribeHandle.Unsubscribe();      
      await view.HideAsync(isImmediately, token);
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    private void OnResume()
    {
      DeactivateAsync().Forget();
      model.stageService.Resume();      
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
      currentIndicator = await model.indicatorService.GetNewAsync(view.IndicatorRoot, view.ResumeProgressFillSubmit.RectTransform);
    }

    private void ReleaseIndicator()
    {      
      model.indicatorService.ReleaseTopIndicator();
      currentIndicator = null;
    }

    private void OnSelectedGameObjectEnter(GameObject gameObject)
    {
      if (gameObject.TryGetComponent<Selectable>(out var selectable))
        currentIndicator.SetLeftInputGuide(selectable.navigation);

      if(gameObject.TryGetComponent<IUIProgressSubmitView>(out var progressSubmitView))
        currentIndicator.SetRightInputGuide(progressSubmitView);
      else
        currentIndicator.SetRightInputGuide(new Direction[0]);
    }
  }
}