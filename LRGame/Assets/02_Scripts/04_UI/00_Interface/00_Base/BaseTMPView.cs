using TMPro;
using UnityEngine;

namespace LR.UI
{
  [RequireComponent(typeof(TextMeshProUGUI))]
  public class BaseTMPView : MonoBehaviour, ITMPView
  {
    private TextMeshProUGUI tmp;
    private TextMeshProUGUI TMP
    {
      get
      {
        if(tmp == null)
          tmp = GetComponent<TextMeshProUGUI>();
        return tmp;
      }
    }

    public virtual void AppendText(string text)
    {
      TMP.text += text;
    }

    public virtual void SetText(string text)
    {
      TMP.text = text;
    }
  }

}