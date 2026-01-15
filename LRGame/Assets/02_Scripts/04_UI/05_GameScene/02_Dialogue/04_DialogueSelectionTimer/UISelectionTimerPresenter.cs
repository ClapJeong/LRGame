using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.GameScene.Dialogue
{
  public class UISelectionTimerPresenter : IUIPresenter
  {
    public class Model
    {
      
    }

    private readonly Model model;
    private readonly UISelectionTimerView view;

    public UISelectionTimerPresenter(Model model, UISelectionTimerView view)
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

    public void SetString(string key)
      => view.subNameLocalize.SetEntry(key);

    public IDisposable SubscribeTimer(FloatReactiveProperty normalizeTime)
      => normalizeTime.Subscribe(value => view.timerImage.localScale = new Vector3(value, 1.0f, 1.0f));
  }
}
