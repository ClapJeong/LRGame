using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.Localization.Components;
using LR.UI.Enum;

namespace LR.UI.GameScene.Dialogue
{
  public class UISelectionTimerView : BaseUIView
  {
    public LocalizeStringEvent subNameLocalize;
    public RectTransform timerImage;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hidden;
      gameObject.SetActive(false);
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Showen;
      gameObject.SetActive(true);
      await UniTask.CompletedTask;
    }
  }
}
