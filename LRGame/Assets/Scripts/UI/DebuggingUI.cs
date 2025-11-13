using UnityEngine;
using UnityEngine.Localization;
using ScriptableEvent;
using TMPro;
using UniRx;
using UniRx.Triggers;
using UnityEngine.UI;

public class DebuggingUI : MonoBehaviour
{
  [SerializeField] private KeyCode enableKeyCode = KeyCode.F1;
  [SerializeField] private GameObject root;
  [SerializeField] private ScriptableEventSO scriptableEventSO;
  [SerializeField] private TextMeshProUGUI selectedStageIndexText;

  private void Update()
  {
    if (Input.GetKeyDown(enableKeyCode))
    {
      root.SetActive(!root.activeInHierarchy);
      LayoutRebuilder.ForceRebuildLayoutImmediate(transform as RectTransform);
    }      

    selectedStageIndexText.text = GlobalManager.instance.selectedStage.ToString();
  }

  public void OnLocaleButtonClicked(Locale locale)
    => scriptableEventSO.OnLocaleChanged(locale);

  public void OnStageButtonClicked(int stageEventType)
    => scriptableEventSO.OnStageEvent((StageEventType)stageEventType);
}
