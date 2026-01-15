using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.Lobby
{
  public class UILobbyRootView : BaseUIView
  {
    [field: SerializeField] public UIMainPanelView MainPanelView { get; private set; }
    [field: SerializeField] public UIChapterPanelView ChapterPanelView {  get; private set; }
    [field: SerializeField] public UIOptionPanelView OptionPanelView { get; private set; }
    [field: SerializeField] public UILocalizePanelView LocalizePanelView { get; private set; }
    [field: SerializeField] public Transform IndicatorRoot { get; private set; }


    public override UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Hidden;
      gameObject.SetActive(false);
      return UniTask.CompletedTask;
    }

    public override UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = VisibleState.Showen;
      gameObject.SetActive(true);
      return UniTask.CompletedTask;
    }
  }
}