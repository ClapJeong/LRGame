using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

[RequireComponent(typeof(TextMeshProUGUI))]
[RequireComponent(typeof(LocalizeStringEvent))]
public class LocalizeFontEvent : MonoBehaviour
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

  private void Start()
    => GlobalManager.instance.LocaleService.Register(this);

  private void OnDestroy()
    => GlobalManager.instance.LocaleService.Unregister(this);

  public void UpdateFont(TMP_FontAsset fontAsset)
  {
    TMP.font = fontAsset;
    TMP.ForceMeshUpdate();
  }
}
