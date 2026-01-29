using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using LR.UI.Enum;
using DG.Tweening;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerEnergyPresenter : IUIPresenter
  {
    public class Model
    {
      public IPlayerReactionController reactionController;
      public IPlayerEnergySubscriber energySubscriber;
      public IPlayerEnergyProvider energyProvider;
      public PlayerEnergyData playerEnergyData;
      public IStageEventSubscriber stageEventSubscriber;
      public UISO uiSO;

      public Model(
        IPlayerReactionController reactionController,
        IPlayerEnergySubscriber energySubscriber,
        IPlayerEnergyProvider energyProvider, 
        PlayerEnergyData playerEnergyData,
        IStageEventSubscriber stageEventSubscriber,
        UISO uiSO)
      {
        this.reactionController = reactionController;
        this.energySubscriber = energySubscriber;
        this.energyProvider = energyProvider;
        this.playerEnergyData = playerEnergyData;
        this.stageEventSubscriber = stageEventSubscriber;
        this.uiSO = uiSO;
      }
    }

    private readonly Model model;
    private readonly UIPlayerEnergyView view;

    private readonly SubscribeHandle subscribeHandle;
    private readonly CTSContainer restoreCTS = new();
    private readonly CTSContainer decayCTS = new();
    private IDisposable viewUpdateObserver;

    private bool isDecay = false;
    private float lastNormalized;
    private float fillNormalized;
    private float valueChangingDuration;

    public UIPlayerEnergyPresenter(Model model, UIPlayerEnergyView view)
    {
      this.model = model;
      this.view = view;

      view.FillImage.fillAmount = 1.0f;
      view.DecayEffectRectTransform.anchoredPosition = new Vector2(0, view.FillImage.rectTransform.rect.height);

      subscribeHandle = new(SubscribePlayerEnergy, UnsubscribePlayerEnergy);
      model.stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.Restart, subscribeHandle.Subscribe);
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      valueChangingDuration = 0.0f;
      subscribeHandle.Subscribe();
      await view.ShowAsync(isImmedieately, token);
    }    

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {      
      await view.HideAsync(isImmedieately, token);
      subscribeHandle.Unsubscribe();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      decayCTS.Dispose();
      restoreCTS.Dispose();
      subscribeHandle.Dispose();
      if (view)
        view.DestroySelf();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    public async UniTask DecreaseForScoreAsync(CancellationToken token)
    {
      subscribeHandle.Unsubscribe();
      try
      {
        var duration = view.FillImage.fillAmount * model.uiSO.ScoreFillMaxDuration;
        await view.FillImage.DOFillAmount(0.0f, duration).ToUniTask(TweenCancelBehaviour.Complete, token);
      }
      catch (OperationCanceledException) { }
    }

    private void SubscribePlayerEnergy()
    {
      viewUpdateObserver = view
        .UpdateAsObservable()
        .Subscribe(_ =>
        {
          UpdateFillNormalized();
          UpdateDecayEffect();

          view.FillImage.SetFillAmount(fillNormalized);
        });
      model.energySubscriber.SubscribeValueEvent(IPlayerEnergySubscriber.ValueEvent.Damaged, OnDamaged);
      model.energySubscriber.SubscribeValueEvent(IPlayerEnergySubscriber.ValueEvent.Restored, OnRestored);
    }

    private void UpdateFillNormalized()
    {
      var currentNormalized = model.energyProvider.CurrentNormalized;

      if (valueChangingDuration > 0.0f)
      {
        var t = 1.0f - valueChangingDuration / model.uiSO.EnergyChangedUIDuration;
        fillNormalized = Mathf.Lerp(lastNormalized, currentNormalized, t);
        valueChangingDuration -= Time.deltaTime;
      }
      else
      {
        fillNormalized = currentNormalized;
      }
    }

    private void UpdateDecayEffect()
    {
      if (isDecay == model.reactionController.IsDecaying)
        return;

      if (model.reactionController.IsDecaying)
      {
        decayCTS.Cancel();
        decayCTS.Create();
        var token = decayCTS.token;
        PlayDecayEffectAsync(token).Forget();
      }
      else
      {
        decayCTS.Cancel();
      }

      isDecay = model.reactionController.IsDecaying;
    }

    private async UniTask PlayDecayEffectAsync(CancellationToken token)
    {      
      var length = view.FillImage.rectTransform.rect.height;
      try
      {
        await DOTween
          .Sequence()
          .Join(view.DecayEffectRectTransform.DOAnchorPosY(-length, model.uiSO.EnergyDecayEffectDuration))
          .AppendInterval(0.2f)
          .SetLoops(-1)
          .OnComplete(() =>
          {
            view.DecayEffectRectTransform.anchoredPosition = new Vector2(0, view.DecayEffectRectTransform.rect.height);
          })
          .ToUniTask(TweenCancelBehaviour.Kill, token);
          
      }
      catch(OperationCanceledException) { }
      finally
      {
        view.DecayEffectRectTransform.anchoredPosition = new Vector2(0, view.FillImage.rectTransform.rect.height);
      }
    }

    private void UnsubscribePlayerEnergy()
    {
      viewUpdateObserver.Dispose();
      model.energySubscriber.UnsubscribeValueEvent(IPlayerEnergySubscriber.ValueEvent.Damaged, OnDamaged);
      model.energySubscriber.UnsubscribeValueEvent(IPlayerEnergySubscriber.ValueEvent.Restored, OnRestored);
    }

    private void OnDamaged(float damagedNormalized)
    {
      lastNormalized = model.energyProvider.CurrentNormalized + damagedNormalized;
      valueChangingDuration = model.uiSO.EnergyChangedUIDuration;
    }

    private void OnRestored(float restoredNormalized)
    {
      lastNormalized = model.energyProvider.CurrentNormalized - restoredNormalized;
      valueChangingDuration = model.uiSO.EnergyChangedUIDuration;
    }
  }
}
