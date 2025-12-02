using Cysharp.Threading.Tasks;
using System;
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
      public float showDuration;
      public float hideDuration;
      public UIInputActionType beginInputType;
      public UnityAction onBeginStage;
      public IUIInputActionManager uiInputActionManager;

      public Model(float showDuration, float hideDuration, UIInputActionType beginInputType, UnityAction onBeginStage, IUIInputActionManager uiInputActionManager)
      {
        this.showDuration = showDuration;
        this.hideDuration = hideDuration;
        this.beginInputType = beginInputType;
        this.onBeginStage = onBeginStage;
        this.uiInputActionManager = uiInputActionManager;
      }
    }

    private UIVisibleState visibleState = UIVisibleState.None;

    private readonly Model model;
    private readonly UIStageBeginViewContainer viewContainer;

    private readonly ICanvasGroupTweenView canvasGroup;
    private readonly ILocalizeStringView beginGuideText;

    public UIStageBeginPresenter(Model model,UIStageBeginViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      this.canvasGroup = viewContainer.canvasGroupView;
      this.beginGuideText = viewContainer.textView;

      beginGuideText.SetArgument(new() { model.beginInputType });
      canvasGroup.DoFadeAsync(1.0f, 0.0f).Forget();

      CreateBeginInputAction();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      
    }

    public UIVisibleState GetVisibleState()
      => visibleState;

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      UnsubscribeInputAction();
      visibleState = UIVisibleState.Hiding;
      await canvasGroup.DoFadeAsync(0.0f,model.hideDuration, token);
      visibleState = UIVisibleState.Hided;
    }


    public async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showing;
      await canvasGroup.DoFadeAsync(1.0f,0.5f,token);
      visibleState = UIVisibleState.Showed;
      SubscribeInputAction();
    }

    private void SubscribeInputAction()
    {
      model.uiInputActionManager.SubscribePerformedEvent(model.beginInputType, OnInputActionPerformed);
    }

    private void UnsubscribeInputAction()
    {
      model.uiInputActionManager.UnsubscribePerformedEvent(model.beginInputType, OnInputActionPerformed);
    }

    private void OnInputActionPerformed()
    {
      model.onBeginStage?.Invoke();
    }
  }
}