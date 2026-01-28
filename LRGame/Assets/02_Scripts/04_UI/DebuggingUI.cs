using UnityEngine;
using UnityEngine.Localization;
using ScriptableEvent;
using TMPro;
using UnityEngine.UI;
using Cysharp.Threading.Tasks;
using System;
using System.Linq;

namespace LR.UI.Debugging
{
  public class DebuggingUI : MonoBehaviour
  {
    [SerializeField] private KeyCode enableKeyCode = KeyCode.F1;
    [SerializeField] private GameObject root;
    [SerializeField] private ScriptableEventSO scriptableEventSO;
    [SerializeField] private TextMeshProUGUI selectedStageIndexText;
    [SerializeField] private TextMeshProUGUI clearStageCountTMP;

    [Header("[ Dialogue Conditions ]")]
    [SerializeField] private GameObject conditionArea;
    [SerializeField] private TextMeshProUGUI currentDialogueConditions;
    [SerializeField] private TMP_InputField conditionKeyInputField;
    [SerializeField] private TMP_InputField conditionLeftInputField;
    [SerializeField] private TMP_InputField conditionRightInputField;

    [Header("[ ChatCard ]")]
    [SerializeField] private TMP_Dropdown chatCardEnumDropdown;

    private void Awake()
    {
      root.SetActive(false);

      chatCardEnumDropdown.ClearOptions();
      var names = System.Enum.GetNames(typeof(ChatCardEnum.ID));
      chatCardEnumDropdown.AddOptions(names.ToList());
    }

    private void Update()
    {
      if (Input.GetKeyDown(enableKeyCode))
      {
        root.SetActive(!root.activeInHierarchy);
        LayoutRebuilder.ForceRebuildLayoutImmediate(transform as RectTransform);
      }

      if (GlobalManager.instance.GameDataService != null)
      {
        GlobalManager
          .instance
          .GameDataService
          .GetSelectedStage(out var chapter, out var stage);
        selectedStageIndexText.text = $"current: {chapter}/{stage}";

        var topClearData =GlobalManager
          .instance
          .GameDataService
          .GetTopClearData();
        clearStageCountTMP.text = $"clear: {Mathf.Max(0, topClearData.ParseIndex())}";
      }     
    }

    public void OnLocaleButtonClicked(Locale locale)
      => scriptableEventSO.OnLocaleChanged(locale);

    public void OnStageButtonClicked(int stageEventType)
      => scriptableEventSO.OnStageEvent((StageEventType)stageEventType);

    public void OnGameDataButtonClicked(int gameDataEventType)
    {
      var type = (GameDataEventType)gameDataEventType;
      switch (type)
      {
        case GameDataEventType.AddDialogueCondition:
          {
            var key = conditionKeyInputField.text;
            if (int.TryParse(conditionLeftInputField.text, out var left) == false ||
                int.TryParse(conditionRightInputField.text, out var right) == false)
              return;

            IGameDataService gameDataService = GlobalManager.instance.GameDataService;
            gameDataService.SetDialogueCondition(key, left, right);
            gameDataService.SaveDataAsync().Forget();
          }
          break;

        default:
          {
            scriptableEventSO.OnGameDataEvent(type);
          }
          break;
      }
    }

    public void OnLeftEnergyButtonClicked(float value)
      => scriptableEventSO.OnLeftEnergyChanged(value);

    public void OnRightEnergyButtonClicked(float value)
      => scriptableEventSO.OnRightEnergyChanged(value);

    public void OnFoldConditionArea()
    {
      var value = !conditionArea.activeSelf;
      if (value)
      {
        currentDialogueConditions.text = GlobalManager.instance.GameDataService.Debugging_GetAllConditions();
        conditionKeyInputField.text = "";
        conditionLeftInputField.text = "";
        conditionRightInputField.text = "";
      }      

      conditionArea.SetActive(value);
      LayoutRebuilder.ForceRebuildLayoutImmediate(conditionArea.GetComponent<RectTransform>());
    }

    public void OnPlayChatCard()
    {
      var index = chatCardEnumDropdown.value;
      scriptableEventSO.PlayChatCard(index);
    }
  }
}