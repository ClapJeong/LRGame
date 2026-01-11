using Cysharp.Threading.Tasks;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UIStageButtonView : BaseUIView
  {
    [field: SerializeField] public BaseProgressSubmitView ProgressSubmitView { get; private set; }
    [field: SerializeField] public Image FillImage {  get; private set; }
    [field: SerializeField] public TextMeshProUGUI TMP {  get; private set; }

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