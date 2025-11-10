using TMPro;
using UnityEngine;

public class UIPreloadingView : MonoBehaviour, ITMPController
{
  [SerializeField] private TextMeshProUGUI loadingText;

  public void AppendText(string text)
    => loadingText.text += text;

  public void SetText(string text)
    => loadingText.text = text;
}
