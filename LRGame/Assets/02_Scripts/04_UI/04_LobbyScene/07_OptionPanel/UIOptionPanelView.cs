using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UIOptionPanelView : UIBaseLobbyPanelView
  {
    [field: SerializeField] public Slider MasterSlider { get; private set; }
    [field: SerializeField] public Slider BGMSlider { get; private set; }
    [field: SerializeField] public Slider SFXSlider { get; private set; }
    [field: Space(5)]
    [field: SerializeField] public Selectable ExitSelectable {  get; private set; }
    [field: SerializeField] public BaseProgressSubmitView ExitProgressSubmit {  get; private set; }
    [field: SerializeField] public Image ExitFillImage { get; private set; }
  }
}
