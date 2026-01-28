using Cysharp.Threading.Tasks;
using LR.UI.Indicator;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;

namespace LR.UI.GameScene.Stage
{
  public class UIStageSuccessPresenter : IUIPresenter
  {
    public class Model
    {
      public IGameDataService gameDataService;
      public IUIIndicatorService indicatorService;
      public ISceneProvider sceneProvider;
      public IStageStateHandler stageService;
      public IUISelectedGameObjectService selectedGameObjectService;
      public IUIDepthService depthService;

      public Model(IGameDataService gameDataService, IUIIndicatorService indicatorService, ISceneProvider sceneProvider, IStageStateHandler stageService, IUISelectedGameObjectService selectedGameObjectService, IUIDepthService depthService)
      {
        this.gameDataService = gameDataService;
        this.indicatorService = indicatorService;
        this.sceneProvider = sceneProvider;
        this.stageService = stageService;
        this.selectedGameObjectService = selectedGameObjectService;
        this.depthService = depthService;
      }
    }

    private readonly Model model;
    private readonly UIStageSuccessView view;

    private readonly SubscribeHandle subscribeHandle;
    private IUIIndicatorPresenter currentIndicator;

    public UIStageSuccessPresenter(Model model, UIStageSuccessView view)
    {
      this.model = model;
      this.view = view;

      view.RestartProgressSubmit.Subscribe(
        Direction.Left,
        onPerformed: null,
        onCanceled: null,
        onProgress: view.RestartFillImage.SetFillAmount,
        onComplete: OnRestart);


      if (IsNextStageExist())
      {
        view.NextProgressFillSubmit.Subscribe(
                view.NextProgressFillSubmit.InputDirection,
                onPerformed: null,
                onCanceled: null,
                onProgress: view.NextProgressFillSubmit.FillImage.SetFillAmount,
                onComplete: OnNext);
      }
      else
      {
        view.NextProgressFillSubmit.gameObject.SetActive(false);
        view.QuitSelectable.AddNavigation(Direction.Right, null);
      }

        view.QuitProgressSubmit.Subscribe(
          Direction.Down,
          onPerformed: null,
          onCanceled: null,
          onProgress: view.QuitFillImage.SetFillAmount,
          onComplete: OnQuit);

      subscribeHandle = new SubscribeHandle(
        () =>
        {
          model.selectedGameObjectService.SubscribeEvent(IUISelectedGameObjectService.EventType.OnEnter, OnSelectedGameObjectEnter);
          model.depthService.RaiseDepth(IsNextStageExist() ? view.NextProgressFillSubmit.gameObject : view.RestartSelectable.gameObject);
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
      model.stageService.Pause();      
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

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

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
      currentIndicator = await model.indicatorService.GetNewAsync(view.IndicatorRoot, view.RestartRect);
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

      if (gameObject.TryGetComponent<IUIProgressSubmitView>(out var progressSubmitView))
        currentIndicator.SetRightInputGuide(progressSubmitView);
      else
        currentIndicator.SetRightInputGuide(new Direction[0]);

      if (gameObject.TryGetComponent<RectTransform>(out var rectTransform))
        currentIndicator.MoveAsync(rectTransform);
    }

    private void OnNext()
    {
      model.gameDataService.GetSelectedStage(out var chapter, out var stage);
      stage += 1;
      var addChapter = stage > 4;
      model.gameDataService.SetSelectedStage(addChapter ? chapter + 1 : chapter, addChapter ? 1 : stage);
      model.sceneProvider.ReloadCurrentSceneAsync().Forget();
    }

    private bool IsNextStageExist()
    {
      model.gameDataService.GetSelectedStage(out var chapter, out var stage);

      stage += 1;
      if (stage > 4)
      {
        chapter++;
        stage = 1;
      }
      return model.gameDataService.IsStageExist(chapter, stage);
    }
  }
}