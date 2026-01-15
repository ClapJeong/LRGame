using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.GameScene.InputQTE
{
  public class UILeftEnergyItemPresenter : IUIInputQTEPresenter
  {
    public class Model
    {

    }

    private readonly Model model;
    private readonly UILeftEnergyItemView view;

    private int count = 0;

    public UILeftEnergyItemPresenter(Model model, UILeftEnergyItemView view)
    {
      this.model = model;
      this.view = view;

      for (int i = 0; i < view.FillImages.Count; i++)
      {
        if (i == 0)
          continue;
        view.FillImages[i].fillAmount = 0.0f;
      }
      for (int i = 0; i < view.TMPs.Count; i++)
      {
        if (i == 0)
          continue;
        view.TMPs[i].text = "";
      }
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmedieately, token);
    }

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.HideAsync(isImmedieately, token);
      Dispose();
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

    public void OnQTEBegin(Direction direction)
    {
      view.FillImages[count].fillAmount = 0.0f;
      view.TMPs[count].text = direction switch
      {
        Direction.Up => "↑",
        Direction.Right => "→",
        Direction.Down => "↓",
        Direction.Left => "←",
        _ => throw new NotImplementedException(),
      };
    }

    public void OnQTECountChanged(int count)
    {
      if (this.count == count)
        return;

      if(count < this.count)
      {
        view.FillImages[this.count].fillAmount = 0.0f;
        view.TMPs[this.count].text = "";
      }

      this.count = count;
    }

    public void OnQTEProgress(float value)
    {
      view.FillImages[count].fillAmount = value;
    }

    public void OnQTEResult(bool isSuccess)
    {
      
    }

    public void OnSequenceBegin()
    {
      
    }

    public void OnSequenceProgress(float value)
    {
      view.SequenceDurationImage.fillAmount = value;
    }

    public void OnSequenceResult(bool isSuccess)
    {
      
    }

    public void SetFollowTransform(Transform transform)
    {
      
    }

    public void SetPosition(Vector2 screenPosition)
    {
      view.RectTransform.position = screenPosition;
    }
  }
}
