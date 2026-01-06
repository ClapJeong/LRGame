using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.GameScene.InputQTE
{
  public class UILeftEnergyItemView : BaseUIView
  {
    [field: SerializeField] public Image SequenceDurationImage { get; private set; }
    [field: SerializeField] public List<Image> FillImages { get; private set; }
    [field: SerializeField] public List<TextMeshProUGUI> TMPs { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hiding;
      await UniTask.CompletedTask;
      visibleState = UIVisibleState.Hidden;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showing;
      await UniTask.CompletedTask;
      visibleState = UIVisibleState.Showen;
    }
  }
}
