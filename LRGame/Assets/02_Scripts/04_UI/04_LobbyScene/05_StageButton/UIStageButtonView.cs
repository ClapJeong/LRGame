using Cysharp.Threading.Tasks;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;
using System.Collections.Generic;

namespace LR.UI.Lobby
{
  public class UIStageButtonView : BaseUIView
  {
    [field: SerializeField] public BaseProgressSubmitView ProgressSubmitView { get; private set; }
    [field: SerializeField] public Image FillImage {  get; private set; }
    [field: SerializeField] public TextMeshProUGUI TMP {  get; private set; }
    [field: SerializeField] public GameObject LeftScore {  get; private set; }
    [field: SerializeField] public GameObject RightScore { get; private set; }

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