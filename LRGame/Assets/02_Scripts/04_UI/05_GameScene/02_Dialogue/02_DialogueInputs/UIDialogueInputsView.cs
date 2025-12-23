using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.GameScene.Dialogue
{
  public class UIDialogueInputsView : BaseUIView
  {
    public Image left;
    public Image right;
    public RectTransform skip;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hidden;
      gameObject.SetActive(false);
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showen;
      gameObject.SetActive(true);
      await UniTask.CompletedTask;
    }
  }
}
