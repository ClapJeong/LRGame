using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerHPPresenter : IUIPresenter
  {
    public class Model
    {
      public int maxHP;
      public IStageService stageService;
      public IPlayerHPController hpController;

      public Model(int maxHP, IStageService stageService, IPlayerHPController hpController)
      {
        this.maxHP = maxHP;
        this.stageService = stageService;
        this.hpController = hpController;
      }
    }

    private readonly Model model;
    private readonly UIPlayerHPView view;

    public UIPlayerHPPresenter(Model model, UIPlayerHPView view)
    {
      this.model = model;
      this.view = view;

      InitializeHPObjects();
      SubscribePresenters();
      SubscribeStageEvent();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      UnsubscribePresenters();
      UnsubscribeStageEvent();
      if (view)
        view.DestroySelf();      
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await view.HideAsync(isImmediately, token);
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmediately, token);
    }

    private void InitializeHPObjects()
    {
      for(int i=0;i< view.hpObjects.Count;i++)
      {
        var isActive = i < model.maxHP;
        view.hpObjects[i].SetActive(isActive);
      }
    }

    private void SubscribePresenters()
    {
      model.hpController.SubscribeOnHPChanged(OnHPChanged);
    }

    private void UnsubscribePresenters()
    {
      model.hpController.UnsubscribeOnHPChanged(OnHPChanged);
    }

    private void SubscribeStageEvent()
    {
      model.stageService.SubscribeOnEvent(IStageService.StageEventType.Restart, InitializeHPObjects);
    }

    private void UnsubscribeStageEvent()
    {
      model.stageService.UnsubscribeOnEvent(IStageService.StageEventType.Restart, InitializeHPObjects);
    }

    private void OnHPChanged(int currentHp)
    {
      for (int i = 0; i < view.hpObjects.Count; i++)
      {
        var isActive = i < currentHp;
        view.hpObjects[i].SetActive(isActive);
      }
    }
  }
}