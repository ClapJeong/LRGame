using UnityEngine;
using UnityEngine.Localization;
using ScriptableEvent;
using TMPro;
using UnityEngine.UI;

namespace LR.UI.Debugging
{
  public class DebuggingUI : MonoBehaviour
  {
    [SerializeField] private KeyCode enableKeyCode = KeyCode.F1;
    [SerializeField] private GameObject root;
    [SerializeField] private ScriptableEventSO scriptableEventSO;
    [SerializeField] private TextMeshProUGUI selectedStageIndexText;
    [SerializeField] private TextMeshProUGUI clearedStageIndexText;

    private void Awake()
    {
      root.SetActive(false);
    }

    private void Update()
    {
      if (Input.GetKeyDown(enableKeyCode))
      {
        root.SetActive(!root.activeInHierarchy);
        LayoutRebuilder.ForceRebuildLayoutImmediate(transform as RectTransform);
      }

      IGameDataService gameDataService = GlobalManager.instance.GameDataService;
      gameDataService.GetSelectedStage(out var chapter, out var stage);
      selectedStageIndexText.text = $"current: {chapter}/{stage}";
      var topClearData = gameDataService.GetTopClearData();
      clearedStageIndexText.text = $"cleared: {topClearData.chapter}/{topClearData.stage}";
    }

    public void OnLocaleButtonClicked(Locale locale)
      => scriptableEventSO.OnLocaleChanged(locale);

    public void OnStageButtonClicked(int stageEventType)
      => scriptableEventSO.OnStageEvent((StageEventType)stageEventType);

    public void OnGameDataButtonClicked(int gameDataEventType)
      => scriptableEventSO.OnGameDataEvent((GameDataEventType)gameDataEventType);

    public void OnLeftHPButtonClicked(int value)
      =>scriptableEventSO.OnLeftHPChanged(value);

    public void OnRightHPButtonClicked(int value)
      => scriptableEventSO.OnRightHPChanged(value);
  }
}