using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;
using System.Collections.Generic;

namespace LR.UI.GameScene.Dialogue
{
  public class UITalkingInputsView : BaseUIView
  {
    [field: SerializeField] public Image Left { get; private set;  }
    [field: SerializeField] public Image Right { get; private set; }
    [field: SerializeField] public RectTransform Skip { get; private set; }
    [field: SerializeField] public List<GameObject> InputEnableIcons { get; private set; }

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
