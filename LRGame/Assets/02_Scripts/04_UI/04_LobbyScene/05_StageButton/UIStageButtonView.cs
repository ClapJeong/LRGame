using Cysharp.Threading.Tasks;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;

namespace LR.UI.Lobby
{
  public class UIStageButtonView : BaseUIView
  {
    [field: SerializeField] public BaseProgressSubmitView ProgressSubmitView { get; private set; }
    [field: SerializeField] public Image FillImage {  get; private set; }
    [field: SerializeField] public TextMeshProUGUI TMP {  get; private set; }

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