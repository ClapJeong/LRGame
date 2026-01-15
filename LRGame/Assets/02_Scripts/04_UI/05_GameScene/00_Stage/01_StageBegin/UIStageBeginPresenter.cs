using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.GameScene.Stage
{
  public class UIStageBeginPresenter : IUIPresenter
  {
    public class Model
    {
      public IUIInputManager uiInputActionManager;
      public IStageStateHandler stageService;

      public Model(IUIInputManager uiInputActionManager, IStageStateHandler stageService)
      {
        this.uiInputActionManager = uiInputActionManager;
        this.stageService = stageService;
      }
    }
    

    private readonly Model model;
    private readonly UIStageBeginView view;

    private SubscribeHandle subscribeHandle;

    private int leftPerfomedCount;
    private int rightPerfomedCount;

    public UIStageBeginPresenter(Model model, UIStageBeginView view)
    {
      this.model = model;
      this.view = view;

      CreateSubscribeHandle();
    }

    public async UniTask DeactivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Unsubscribe();
      await view.HideAsync(isImmediately, token);
    }

    public async UniTask ActivateAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Subscribe();
      await view.ShowAsync(isImmediately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    private void CreateSubscribeHandle()
    {
      var leftInputs = new List<InputDirection>()
            {
              InputDirection.LeftUp,
              InputDirection.LeftRight,
              InputDirection.LeftDown,
              InputDirection.LeftLeft,
            };

      var rightInputs = new List<InputDirection>()
            {
              InputDirection.RightUp,
              InputDirection.RightRight,
              InputDirection.RightDown,
              InputDirection.RightLeft,
            };

      subscribeHandle = new SubscribeHandle(
        onSubscribe: () =>
        {
          leftPerfomedCount = 0;
          rightPerfomedCount = 0;
          foreach (var leftInput in leftInputs)
            if (model.uiInputActionManager.IsPerforming(leftInput))
              leftPerfomedCount++;

          foreach (var rightInput in rightInputs)
            if (model.uiInputActionManager.IsPerforming(rightInput))
              rightPerfomedCount++;

          model.uiInputActionManager.SubscribePerformedEvent(leftInputs, OnLeftPerformed);
          model.uiInputActionManager.SubscribeCanceledEvent(leftInputs, OnLeftCanceled);

          model.uiInputActionManager.SubscribePerformedEvent(rightInputs, OnRightPerformed);
          model.uiInputActionManager.SubscribeCanceledEvent(rightInputs, OnRightCanceled);
        },
        onUnsubscribe: () =>
        {
          leftPerfomedCount = 0;
          rightPerfomedCount = 0;

          model.uiInputActionManager.UnsubscribePerformedEvent(leftInputs, OnLeftPerformed);
          model.uiInputActionManager.UnsubscribeCanceledEvent(leftInputs, OnLeftCanceled);

          model.uiInputActionManager.UnsubscribePerformedEvent(rightInputs, OnRightPerformed);
          model.uiInputActionManager.UnsubscribeCanceledEvent(rightInputs, OnRightCanceled);
        });
    }

    private void OnLeftPerformed()
    {
      leftPerfomedCount++;
      view.LeftReadyImage.SetAlpha(1.0f);

      if (IsPlayble())
        BeginStage();
    }
    
    private void OnLeftCanceled()
    {
      leftPerfomedCount--;
      if (leftPerfomedCount == 0)
        view.LeftReadyImage.SetAlpha(0.4f);
    }

    private void OnRightPerformed()
    {
      rightPerfomedCount++;
      view.RightReadyImage.SetAlpha(1.0f);

      if (IsPlayble())
        BeginStage();
    }

    private void OnRightCanceled()
    {
      rightPerfomedCount--;
      if (rightPerfomedCount == 0)
        view.RightReadyImage.SetAlpha(0.4f);
    }

    private bool IsPlayble()
      => rightPerfomedCount > 0 && leftPerfomedCount > 0;

    private void BeginStage()
    {
      model.stageService.Begin();
      DeactivateAsync().Forget();
    }
  }
}