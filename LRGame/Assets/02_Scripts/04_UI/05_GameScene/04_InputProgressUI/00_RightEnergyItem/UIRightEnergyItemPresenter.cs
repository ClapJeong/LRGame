using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;

namespace LR.UI.GameScene.InputProgress
{
  public class UIRightEnergyItemPresenter : IUIInputProgressPresenter
  {
    public class Model
    {
      
    }

    private readonly Model model;
    private readonly UIRightEnergyItemView view;

    public UIRightEnergyItemPresenter(Model model, UIRightEnergyItemView view)
    {
      this.model = model;
      this.view = view;
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

    public void SetFollowTransform(Transform transform)
    {
      throw new NotImplementedException();
    }

    public void SetPosition(Vector2 screenPosition)
    {
      view.RectTransform.position = screenPosition;
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

    public void OnProgress(float normalizedValue)
    {
      view.fillImage.fillAmount = normalizedValue;
    }

    public void OnComplete()
    {

    }

    public void OnFail()
    {

    }
  }
}
