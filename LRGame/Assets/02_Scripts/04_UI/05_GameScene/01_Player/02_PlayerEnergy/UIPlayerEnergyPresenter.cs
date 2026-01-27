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
      public IPlayerEnergyProvider energyProvider;
      public PlayerEnergyData playerEnergyData;
      public IStageEventSubscriber stageEventSubscriber;
      public UISO uiSO;

      public Model(
        IPlayerEnergyProvider energyProvider, 
        PlayerEnergyData playerEnergyData,
        IStageEventSubscriber stageEventSubscriber,
        UISO uiSO)
      {
        this.energyProvider = energyProvider;
        this.playerEnergyData = playerEnergyData;
        this.stageEventSubscriber = stageEventSubscriber;
        this.uiSO = uiSO;
      }
    }

    private readonly Model model;
    private readonly UIPlayerEnergyView view;

    private readonly SubscribeHandle subscribeHandle;
    private IDisposable viewUpdateObserver;

    public UIPlayerEnergyPresenter(Model model, UIPlayerEnergyView view)
    {
      this.model = model;
      this.view = view;

      view.FillImage.fillAmount = 1.0f;

      subscribeHandle = new(SubscribePlayerEnergy, UnsubscribePlayerEnergy);
      model.stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.Restart, subscribeHandle.Subscribe);
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
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
          var normalized = model.energyProvider.CurrentEnergy / model.playerEnergyData.MaxEnergy;
          view.FillImage.SetFillAmount(normalized);
        });
    }

    private void UnsubscribePlayerEnergy()
    {
      viewUpdateObserver.Dispose();
    }
  }
}