using Cysharp.Threading.Tasks;
using DG.Tweening;
using LR.Stage.Player;
using LR.Stage.Player.Enum;
using LR.Stage.StageDataContainer;
using LR.UI.Enum;
using System;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerScorePresenter : IUIPresenter
  {
    public class Model
    {
      public IGameDataService gameDataService;
      public UISO uiSO;
      public IPlayerEnergyProvider energyProvider;
      public PlayerType playerType;
      public ScoreData scoreData;
      public IStageEventSubscriber stageEventSubscriber;

      public Model(
        UISO uiSO,
        IGameDataService gameDataService,
        IPlayerEnergyProvider energyProvider, 
        PlayerType playerType, 
        ScoreData scoreData,
        IStageEventSubscriber stageEventSubscriber)
      {
        this.uiSO = uiSO;
        this.gameDataService = gameDataService;
        this.energyProvider = energyProvider;
        this.playerType = playerType;
        this.scoreData = scoreData;
        this.stageEventSubscriber = stageEventSubscriber;
      }
    }

    private readonly Model model;
    private readonly UIPlayerScoreView view;

    private bool isScoreAcquired;

    public UIPlayerScorePresenter(Model model, UIPlayerScoreView view)
    {
      this.model = model;
      this.view = view;

      model.stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.Restart, () =>
      {
        DeactivateAsync(true).Forget();
      });

      UpdateScoreMarkAlpha();

      var targetScoreNormalized = model.scoreData.GetValue(model.playerType);
      var sign = model.playerType switch
      {
        PlayerType.Left => 1.0f,
        PlayerType.Right => -1.0f,
        _ => throw new System.NotImplementedException(),
      };
      var targetX = view.FillImage.rectTransform.rect.width * targetScoreNormalized * sign;
      view.ScoreMarkerRectTransform.anchoredPosition = new Vector2(targetX , 0.0f);
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {     
      await view.ShowAsync(isImmedieately, token);
    }

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.HideAsync(isImmedieately, token);
      UpdateScoreMarkAlpha();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (view)
        view.DestroySelf();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    public async UniTask FillAmountAsync(CancellationToken token)
    {
      try
      {
        var fillNormalized = model.energyProvider.CurrentNormalized;
        var fillDuration = fillNormalized * model.uiSO.ScoreFillMaxDuration;

        var markerNormalized = model.scoreData.GetValue(model.playerType);
        bool markerShown = false;

        var tween = view.FillImage
          .DOFillAmount(fillNormalized, fillDuration)
          .OnUpdate(() =>
          {
            if (!markerShown &&
                view.FillImage.fillAmount >= markerNormalized)
            {
              markerShown = true;
              view.ScoreMarkerImage.SetAlpha(1.0f);
            }
          });

        await tween.ToUniTask(TweenCancelBehaviour.Complete, token);
      }
      catch (OperationCanceledException) { }
    }

    private void UpdateScoreMarkAlpha()
    {
      model.gameDataService.GetSelectedStage(out var chapter, out var stage);
      model.gameDataService.GetScoreData(chapter, stage, out var left, out var right);
      isScoreAcquired = model.playerType switch
      {
        PlayerType.Left => left,
        PlayerType.Right => right,
        _ => throw new NotImplementedException(),
      };

      view.ScoreMarkerImage.SetAlpha(isScoreAcquired ? 0.5f : 0.0f);
    }
  }
}
