using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIChapterPanelViewContainer : MonoBehaviour
  {
    [Header("[ Base ]")]
    public BaseGameObjectView gameObjectView;
    public Transform indicatorRoot;

    [Header("[ StageButtons ]")]
    public UIStageButtonViewContainer upStageButtonView;
    public UIStageButtonViewContainer rightStageButtonView;
    public UIStageButtonViewContainer downStageButtonView;
    public UIStageButtonViewContainer leftStageButtonView;

    [Header("[ Quit ]")]
    public UIChapterPanelQuitButtonViewContainer quitButtonView;
  }
}