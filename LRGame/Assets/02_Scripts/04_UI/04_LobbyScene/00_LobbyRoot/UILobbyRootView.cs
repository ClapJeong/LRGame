using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UILobbyRootView : BaseUIView
  {
    [field: SerializeField] public UIMainPanelView MainPanelView { get; private set; }
    [field: SerializeField] public UIChapterPanelView ChapterPanelView {  get; private set; }
    [field: SerializeField] public Transform IndicatorRoot { get; private set; }


    public override UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hidden;
      return UniTask.CompletedTask;
    }

    public override UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showen;
      return UniTask.CompletedTask;
    }
  }
}