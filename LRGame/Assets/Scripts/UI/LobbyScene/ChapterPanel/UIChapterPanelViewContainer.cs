using UnityEngine;

namespace LR.UI.Lobby
{
  public class UIChapterPanelViewContainer : MonoBehaviour
  {
    [Header("[ Base ]")]
    public BaseGameObjectView gameObjectView;
    public Transform stageButtonRoot;

    [Header("[ StageButtons ]")]
    public UIStageButtonViewContainer upStageButtonView;
    public UIStageButtonViewContainer rightStageButtonView;
    public UIStageButtonViewContainer downStageButtonView;
    public UIStageButtonViewContainer leftStageButtonView;

    [Header("[ Quit ]")]
    public UIChapterPanelQuitButtonViewContainer quitButtonView;
  }
}