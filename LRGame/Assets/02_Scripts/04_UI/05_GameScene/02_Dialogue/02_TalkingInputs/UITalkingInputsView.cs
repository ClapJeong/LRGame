using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;

namespace LR.UI.GameScene.Dialogue
{
  public class UITalkingInputsView : BaseUIView
  {
    public Image left;
    public Image right;
    public RectTransform skip;

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
