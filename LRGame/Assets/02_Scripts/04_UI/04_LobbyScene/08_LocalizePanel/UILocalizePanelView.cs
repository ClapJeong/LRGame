using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UILocalizePanelView : UIBaseLobbyPanelView
  {
    [System.Serializable]
    public class ButtonSet
    {
      [field: SerializeField] public Locale Locale { get; private set;  }
      [field: SerializeField] public BaseProgressSubmitView ProgressSubmitView {  get; private set; }
      [field: SerializeField] public Image FillImage {  get; private set; }
      [field: SerializeField] public RectTransform RectTransform {  get; private set; }
    }

    [field: SerializeField] public List<ButtonSet> ButtonSets {  get; private set; }
    [field: Space(5)]
    [field: SerializeField] public RectTransform ExitRectTransform { get; private set; }
    [field: SerializeField] public BaseProgressSubmitView ExitProgressSubmit { get; private set; }
    [field: SerializeField] public Image ExitFillImage { get; private set; }

  }
}
