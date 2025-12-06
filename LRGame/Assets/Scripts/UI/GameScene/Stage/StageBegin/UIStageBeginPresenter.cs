using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace LR.UI.GameScene.Stage
{
  public class UIStageBeginPresenter : IUIPresenter
  {
    public class Model
    {
      public IUIInputActionManager uiInputActionManager;
      public IStageService stageService;

      public Model(IUIInputActionManager uiInputActionManager, IStageService stageService)
      {
        this.uiInputActionManager = uiInputActionManager;
        this.stageService = stageService;
      }
    }
    

    private readonly Model model;
    private readonly UIStageBeginViewContainer viewContainer;

    private UIVisibleState visibleState = UIVisibleState.None;
    private SubscribeHandle subscribeHandle;

    private int leftPerfomedCount;
    private int rightPerfomedCount;

    public UIStageBeginPresenter(Model model, UIStageBeginViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      CreateSubscribeHandle();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    public UIVisibleState GetVisibleState()
      => visibleState;

    public void SetVisibleState(UIVisibleState visibleState)
      => this.visibleState = visibleState;

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      subscribeHandle.Unsubscribe();
      viewContainer.gameObjectView.SetActive(false);
      visibleState = UIVisibleState.Hided;
      return UniTask.CompletedTask;
    }


    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      viewContainer.leftImageView.SetAlpha(0.4f);
      viewContainer.rightImageView.SetAlpha(0.4f);
      subscribeHandle.Subscribe();
      viewContainer.gameObjectView.SetActive(true);
      visibleState = UIVisibleState.Showed;
      return UniTask.CompletedTask;
    }

    private void CreateSubscribeHandle()
    {
      var leftInputs = new List<UIInputDirectionType>()
            {
              UIInputDirectionType.LeftUp,
              UIInputDirectionType.LeftRight,
              UIInputDirectionType.LeftDown,
              UIInputDirectionType.LeftLeft,
            };

      var rightInputs = new List<UIInputDirectionType>()
            {
              UIInputDirectionType.RightUP,
              UIInputDirectionType.RightRight,
              UIInputDirectionType.RightDown,
              UIInputDirectionType.RightLeft,
            };

      subscribeHandle = new SubscribeHandle(
        onSubscribe: () =>
        {
          model.uiInputActionManager.SubscribePerformedEvent(leftInputs, OnLeftPerformed);
          model.uiInputActionManager.SubscribeCanceledEvent(leftInputs, OnLeftCanceled);

          model.uiInputActionManager.SubscribePerformedEvent(rightInputs, OnRightPerformed);
          model.uiInputActionManager.SubscribeCanceledEvent(rightInputs, OnRightCanceled);
        },
        onUnsubscribe: () =>
        {
          model.uiInputActionManager.UnsubscribePerformedEvent(leftInputs, OnLeftPerformed);
          model.uiInputActionManager.UnsubscribeCanceledEvent(leftInputs, OnLeftCanceled);

          model.uiInputActionManager.UnsubscribePerformedEvent(rightInputs, OnRightPerformed);
          model.uiInputActionManager.UnsubscribeCanceledEvent(rightInputs, OnRightCanceled);
        });
    }

    private void OnLeftPerformed()
    {
      leftPerfomedCount++;
      viewContainer.leftImageView.SetAlpha(1.0f);

      if (IsPlayble())
        BeginStage();
    }
    
    private void OnLeftCanceled()
    {
      leftPerfomedCount--;
      if (leftPerfomedCount == 0)
        viewContainer.leftImageView.SetAlpha(0.4f);
    }

    private void OnRightPerformed()
    {
      rightPerfomedCount++;
      viewContainer.rightImageView.SetAlpha(1.0f);

      if (IsPlayble())
        BeginStage();
    }

    private void OnRightCanceled()
    {
      rightPerfomedCount--;
      if (rightPerfomedCount == 0)
        viewContainer.rightImageView.SetAlpha(0.4f);
    }

    private bool IsPlayble()
      => rightPerfomedCount > 0 && leftPerfomedCount > 0;

    private void BeginStage()
    {
      model.stageService.Begin();
      HideAsync().Forget();
    }
  }
}