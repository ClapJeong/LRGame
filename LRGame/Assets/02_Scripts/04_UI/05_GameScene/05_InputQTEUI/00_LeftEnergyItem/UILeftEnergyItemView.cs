using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;

namespace LR.UI.GameScene.InputQTE
{
  public class UILeftEnergyItemView : BaseUIView
  {
    [field: SerializeField] public Image SequenceDurationImage { get; private set; }
    [field: SerializeField] public List<Image> FillImages { get; private set; }
    [field: SerializeField] public List<TextMeshProUGUI> TMPs { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hiding;
      await UniTask.CompletedTask;
      visibleState = VisibleState.Hidden;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Showing;
      await UniTask.CompletedTask;
      visibleState = VisibleState.Showen;
    }
  }
}
