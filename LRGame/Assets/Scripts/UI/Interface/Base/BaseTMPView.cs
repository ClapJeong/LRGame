using TMPro;
using UnityEngine;

namespace LR.UI
{
  [RequireComponent(typeof(TextMeshProUGUI))]
  public class BaseTMPView : MonoBehaviour, ITMPView
  {
    private TextMeshProUGUI tmp;

    private void Awake()
    {
      tmp = GetComponent<TextMeshProUGUI>();
    }

    public virtual void AppendText(string text)
    {
      tmp.text += text;
    }

    public virtual void SetText(string text)
    {
      tmp.text = text;
    }
  }

}