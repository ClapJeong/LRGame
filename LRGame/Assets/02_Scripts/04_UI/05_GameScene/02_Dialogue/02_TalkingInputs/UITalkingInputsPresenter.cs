using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using System;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.Dialogue
{
  public class UITalkingInputsPresenter : IUIPresenter
  {
    public class Model
    {
      public UITextPresentationData textPresentationData;

      public Model(UITextPresentationData textPresentationData)
      {
        this.textPresentationData = textPresentationData;
      }
    }

    private readonly Model model;
    private readonly UITalkingInputsView view;

    public UITalkingInputsPresenter(Model model, UITalkingInputsView view)
    {
      this.model = model;
      this.view = view;
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      DeactivateLeftInput();
      DeactivateRightInput();
      SkipProgress(0.0f);
      await view.ShowAsync(isImmedieately, token);
    }    

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.HideAsync(isImmedieately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if (view)
        view.DestroySelf();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    public void ActivateLeftInput()
      => view.left.SetAlpha(model.textPresentationData.InputPerformedAlpha);

    public void DeactivateLeftInput()
      => view.left.SetAlpha(model.textPresentationData.InputCanceledAlpha);

    public void ActivateRightInput()
      => view.right.SetAlpha(model.textPresentationData.InputPerformedAlpha);

    public void DeactivateRightInput()
      => view.right.SetAlpha(model.textPresentationData.InputCanceledAlpha);

    public void SkipProgress(float value)
      => view.skip.localScale = Vector3.one * value;
  }
}
