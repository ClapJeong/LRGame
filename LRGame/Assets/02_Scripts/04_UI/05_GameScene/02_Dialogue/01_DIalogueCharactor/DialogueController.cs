using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using System;
using System.Threading;
using TMPro;

namespace LR.UI.GameScene.Dialogue.Character
{
  public class DialogueController
  {
    private readonly UIDialogueCharacterView view;
    private readonly TextPresentationData tableData;

    private readonly CTSContainer dialogueCTS = new();

    public DialogueController(UIDialogueCharacterView view, TextPresentationData tableData)
    {
      this.view = view;
      this.tableData = tableData;
    }

    public void SetName(string key)
    {
      if (string.IsNullOrEmpty(key))
      {
        view.nameRoot.SetActive(false);
      }
      else
      {
        view.nameLocalize.SetEntry(key);
        view.nameRoot.SetActive(true);
      }
    }

    public void SetDialogue(string key)
    {
      dialogueCTS.Cancel();
      dialogueCTS.Create();
      if (string.IsNullOrEmpty(key))
      {
        view.dialogueTMP.text = "";
      }
      else
      {
        SetDialogueAsync(key, dialogueCTS.token).Forget();
      }
    }

    private async UniTask SetDialogueAsync(string key, CancellationToken token)
    {
      try
      {
        string resolvedText = null;

        void OnUpdate(string value) => resolvedText = value;

        view.dialogueLocalize.OnUpdateString.AddListener(OnUpdate);
        view.dialogueLocalize.SetEntry(key);

        await UniTask.WaitUntil(
            () => resolvedText != null,
            cancellationToken: token);

        view.dialogueLocalize.OnUpdateString.RemoveListener(OnUpdate);

        await TypewriterRichTextAsync(
            view.dialogueTMP,
            resolvedText,
            tableData.CharacterInterval,
            token);
      }
      catch (OperationCanceledException) { }
    }

    private async UniTask TypewriterRichTextAsync(
    TMP_Text text,
    string fullText,
    float charInterval,
    CancellationToken token)
    {
      text.text = fullText;
      text.ForceMeshUpdate();

      var textInfo = text.textInfo;
      int totalVisibleChars = textInfo.characterCount;

      text.text = fullText;
      text.maxVisibleCharacters = 0;

      for (int visibleCount = 1; visibleCount <= totalVisibleChars; visibleCount++)
      {
        token.ThrowIfCancellationRequested();

        text.maxVisibleCharacters = visibleCount;

        await UniTask.Delay(
            TimeSpan.FromSeconds(charInterval),
            cancellationToken: token);
      }
    }
  }
}
