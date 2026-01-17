using Cysharp.Threading.Tasks;
using Febucci.TextAnimatorCore.Typing;
using Febucci.TextAnimatorForUnity;
using Febucci.TextAnimatorForUnity.TextMeshPro;
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
    private readonly GameObject dialogueBackground;
    private readonly CanvasGroup nameCanvasGroup;
    private readonly LocalizeStringEvent nameLocalize;
    private readonly LocalizeStringEvent dialogueLocalize;
    private readonly TextMeshProUGUI dialogueTMP;
    private readonly TextAnimator_TMP animatorTMP;
    private readonly TypewriterComponent typewriter;

    private readonly CTSContainer dialogueCTS = new();

    private bool isTyping = false;

    public TextController(
      UITextPresentationData tableData,
      GameObject dialogueBackground,
      CanvasGroup nameCanvasGroup, 
      LocalizeStringEvent nameLocalize, 
      LocalizeStringEvent dialogueLocalize, 
      TextMeshProUGUI dialogueTMP,
      TextAnimator_TMP animatorTMP,
      TypewriterComponent typewriter)
    {
      this.tableData = tableData;
      this.dialogueBackground = dialogueBackground;
      this.nameCanvasGroup = nameCanvasGroup;
      this.nameLocalize = nameLocalize;
      this.dialogueLocalize = dialogueLocalize;
      this.dialogueTMP = dialogueTMP;      
      this.animatorTMP = animatorTMP;
      this.typewriter = typewriter;

      dialogueBackground.SetActive(false);
      typewriter.onMessage.AddListener(OnTypeComplete);
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
        dialogueBackground.SetActive(false);
        ClearText();
      }
      else
      {
        isTyping = true;
        dialogueBackground.SetActive(true);
        await SetLocalizeKeyAsync(key, dialogueCTS.token);
        var originText = dialogueTMP.text;
        var typingText = dialogueTMP.text + "<?OnTypeComplete>";        
        try
        {
          typewriter.ShowText(typingText);
          await UniTask.WaitUntil(() => isTyping == false, PlayerLoopTiming.Update, dialogueCTS.token);
        }
        catch (OperationCanceledException)
        {
          animatorTMP.SetText(dialogueTMP.text);
          isTyping = false;
        }       
      }
    }

    private void OnTypeComplete(EventMarker marker)
    {
      isTyping = false;
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
