using Cysharp.Threading.Tasks;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UIChapterPanelExitButtonView : BaseUIView
  {
    [field: SerializeField] public Selectable Selectable { get; private set; }
    [field: SerializeField] public BaseProgressSubmitView ProgressSubmitView { get; private set; }
    [field: SerializeField] public Image FillImage { get; private set; }

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
