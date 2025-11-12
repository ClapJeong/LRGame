using UnityEngine;
using UnityEngine.Localization;

public class DebuggingUI : MonoBehaviour
{
  [SerializeField] private KeyCode enableKeyCode = KeyCode.F1;
  [SerializeField] private GameObject root;
  [SerializeField] private ScriptableEventSO scriptableEventSO;

  private void Update()
  {
    if (Input.GetKeyDown(enableKeyCode))
      root.SetActive(!root.activeInHierarchy);
  }

  public void OnLocaleButtonClicked(Locale locale)
    => scriptableEventSO.OnLocaleChanged(locale);
}
