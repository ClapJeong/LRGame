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

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      subscribeHandle.Dispose();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

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
      view.leftImageView.SetAlpha(1.0f);

      if (IsPlayble())
        BeginStage();
    }
    
    private void OnLeftCanceled()
    {
      leftPerfomedCount--;
      if (leftPerfomedCount == 0)
        view.leftImageView.SetAlpha(0.4f);
    }

    private void OnRightPerformed()
    {
      rightPerfomedCount++;
      view.rightImageView.SetAlpha(1.0f);

      if (IsPlayble())
        BeginStage();
    }

    private void OnRightCanceled()
    {
      rightPerfomedCount--;
      if (rightPerfomedCount == 0)
        view.rightImageView.SetAlpha(0.4f);
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