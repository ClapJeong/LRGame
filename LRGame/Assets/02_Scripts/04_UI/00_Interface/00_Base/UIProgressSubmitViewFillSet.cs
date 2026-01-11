using UnityEngine;
using UnityEngine.UI;

namespace LR.UI
{
  public class UIProgressSubmitViewFillSet : BaseProgressSubmitView
  {
    [field: SerializeField] public RectTransform RectTransform {  get; set; }
    [field: SerializeField] public Direction InputDirection { get; set; }
    [field: SerializeField] public Image FillImage {  get; set; }
  }
}
