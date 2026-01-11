using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.Lobby
{
  public class UIMainPanelView : UIBaseLobbyPanelView
  {
    [System.Serializable]
    public class ButtonSet
    {
      [field: SerializeField] public RectTransform RectTransform {  get; set; }
      [field: SerializeField] public BaseProgressSubmitView ProgressSubmit { get; private set; }
      [field: SerializeField] public Image FillImage { get; private set; }
    }
    [field: SerializeField] public ButtonSet OptionButtonSet { get; private set; }
    [field: SerializeField] public ButtonSet LocalizeButtonSet { get; private set; }
    [field: SerializeField] public ButtonSet StageButtonSet { get; private set; }

    [field: Space(5)]
    [field: SerializeField] public BaseProgressSubmitView QuitProgressSubmit { get; private set; }
    [field: SerializeField] public RectTransform QuitRect { get; private set; }
    [field: SerializeField] public RectTransform QuitRectFillImage {  get; private set; }
  }
}
