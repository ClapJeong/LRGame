using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using System;
using System.Threading;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime;

namespace LR.UI.GameScene.Dialogue.Character
{
  public class TalkingController
  {
    private readonly UITalkingCharacterView view;
    private readonly UITextPresentationData tableData;

    private readonly CTSContainer dialogueCTS = new();

    public TalkingController(UITalkingCharacterView view, UITextPresentationData tableData)
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

    public async UniTask SetDialogueAsync(string key)
    {
      dialogueCTS.Cancel();
      dialogueCTS.Create();
      if (string.IsNullOrEmpty(key))
      {
        view.dialogueTMP.text = "";
      }
      else
      {
        await SetLocalizeKeyAsync(key, dialogueCTS.token);
        await view.dialogueTMP.TypeRichTextAsync(tableData.CharacterInterval, dialogueCTS.token);
        //await TypewriterRichTextAsync(
        //  view.dialogueTMP,
        //  view.dialogueTMP.text,
        //  tableData.CharacterInterval,
        //  dialogueCTS.token);
      }
    }

    private async UniTask SetLocalizeKeyAsync(string key, CancellationToken token)
    {
      string resolvedText = null;

      void OnUpdate(string value) => resolvedText = value;
      try
      {

        view.dialogueLocalize.OnUpdateString.AddListener(OnUpdate);
        view.dialogueLocalize.SetEntry(key);

        await UniTask.WaitUntil(
            () => resolvedText != null,
            cancellationToken: token);        
      }
      catch (OperationCanceledException) { }
      finally
      {
        view.dialogueLocalize.OnUpdateString.RemoveListener(OnUpdate);
      }
    }

    public void CompleteDialogueImmediately()
      => dialogueCTS.Cancel();

    private async UniTask TypewriterRichTextAsync(
    TextMeshProUGUI text,
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

      try
      {
        for (int visibleCount = 1; visibleCount <= totalVisibleChars; visibleCount++)
        {
          token.ThrowIfCancellationRequested();

          text.maxVisibleCharacters = visibleCount;

          await UniTask.Delay(
              TimeSpan.FromSeconds(charInterval),
              cancellationToken: token);
        }
      }
      catch (OperationCanceledException) { }
      finally
      {
        text.maxVisibleCharacters = totalVisibleChars;
      }
    }
  }
}
