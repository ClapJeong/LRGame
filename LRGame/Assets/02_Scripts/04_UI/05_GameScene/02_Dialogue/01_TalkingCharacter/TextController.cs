using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using System;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace LR.UI.GameScene.Dialogue.Character
{
  public class TextController
  {
    private readonly UITextPresentationData tableData;
    private readonly CanvasGroup nameCanvasGroup;
    private readonly LocalizeStringEvent nameLocalize;
    private readonly LocalizeStringEvent dialogueLocalize;
    private readonly TextMeshProUGUI dialogueTMP;    

    private readonly CTSContainer dialogueCTS = new();

    public TextController(UITextPresentationData tableData, CanvasGroup nameCanvasGroup, LocalizeStringEvent nameLocalize, LocalizeStringEvent dialogueLocalize, TextMeshProUGUI dialogueTMP)
    {
      this.tableData = tableData;
      this.nameCanvasGroup = nameCanvasGroup;
      this.nameLocalize = nameLocalize;
      this.dialogueLocalize = dialogueLocalize;
      this.dialogueTMP = dialogueTMP;      
    }

    public void SetName(string key)
    {
      if (string.IsNullOrWhiteSpace(key))
      {
        nameCanvasGroup.alpha = 0.0f;
      }
      else
      {
        nameLocalize.SetEntry(key);
        nameCanvasGroup.alpha = 1.0f;
      }
    }

    public async UniTask SetDialogueAsync(string key)
    {
      dialogueCTS.Cancel();
      dialogueCTS.Create();
      if (string.IsNullOrWhiteSpace(key))
      {
        ClearText();
      }
      else
      {
        await SetLocalizeKeyAsync(key, dialogueCTS.token);
        await dialogueTMP.TypeRichTextAsync(tableData.CharacterInterval, dialogueCTS.token);
      }
    }

    private async UniTask SetLocalizeKeyAsync(string key, CancellationToken token)
    {
      string resolvedText = null;

      void OnUpdate(string value) => resolvedText = value;
      try
      {
        dialogueLocalize.OnUpdateString.AddListener(OnUpdate);
        dialogueLocalize.SetEntry(key);

        await UniTask.WaitUntil(
            () => resolvedText != null,
            cancellationToken: token);        
      }
      catch (OperationCanceledException) { }
      finally
      {
        dialogueLocalize.OnUpdateString.RemoveListener(OnUpdate);
      }
    }

    public void CompleteDialogueImmediately()
      => dialogueCTS.Cancel();

    public void ClearName()
    {
      nameCanvasGroup.alpha = 0.0f;
    }

    public void ClearText()
    {
      dialogueLocalize.SetEntry("");
      dialogueTMP.text = "";
    }
  }
}
