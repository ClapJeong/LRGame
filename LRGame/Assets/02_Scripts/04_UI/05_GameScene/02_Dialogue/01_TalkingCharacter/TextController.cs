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
    private readonly GameObject nameRoot;
    private readonly LocalizeStringEvent nameLocalize;
    private readonly LocalizeStringEvent dialogueLocalize;
    private readonly TextMeshProUGUI dialogueTMP;    

    private readonly CTSContainer dialogueCTS = new();

    public TextController(UITextPresentationData tableData, GameObject nameRoot, LocalizeStringEvent nameLocalize, LocalizeStringEvent dialogueLocalize, TextMeshProUGUI dialogueTMP)
    {
      this.tableData = tableData;
      this.nameRoot = nameRoot;
      this.nameLocalize = nameLocalize;
      this.dialogueLocalize = dialogueLocalize;
      this.dialogueTMP = dialogueTMP;      
    }

    public void SetName(string key)
    {
      if (string.IsNullOrEmpty(key))
      {
        nameRoot.SetActive(false);
      }
      else
      {
        nameLocalize.SetEntry(key);
        nameRoot.SetActive(true);
      }
    }

    public async UniTask SetDialogueAsync(string key)
    {
      dialogueCTS.Cancel();
      dialogueCTS.Create();
      if (string.IsNullOrEmpty(key))
      {
        dialogueTMP.text = "";
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
  }
}
