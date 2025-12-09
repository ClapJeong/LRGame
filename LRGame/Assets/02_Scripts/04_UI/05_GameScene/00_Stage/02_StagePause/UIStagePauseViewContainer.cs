using LR.UI.GameScene.Stage.PausePanel;
using UnityEngine;

namespace LR.UI.GameScene.Stage
{
  public class UIStagePauseViewContainer : MonoBehaviour
  {
    [Header("[ Base ]")]
    public BaseGameObjectView gameObjectView;
    public Transform IndicatorRoot;

    [Header("[ ResumeButton ]")]
    public ResumeButtonViewContainer resumeButtonViewContainer;

    [Header("[ RestartButton ]")]
    public BaseButtonViewContainer restartButtonViewContainer;

    [Header("[ QuitButton ]")]
    public BaseButtonViewContainer quitButtonViewContainer;
  }
}