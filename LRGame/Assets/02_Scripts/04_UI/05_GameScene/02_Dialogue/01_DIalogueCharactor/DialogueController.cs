using Cysharp.Threading.Tasks;
using DG.Tweening;
using LR.Table.Dialogue;
using System;
using System.Threading;

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
        view.dialogueLocalize.SetEntry(key);
        view.dialogueTMP.maxVisibleCharacters = 0;

        await DOTween.To(
            () => view.dialogueTMP.maxVisibleCharacters,
            x => view.dialogueTMP.maxVisibleCharacters = x,
            view.dialogueTMP.textInfo.characterCount,
            tableData.CharacterInterval).ToUniTask(TweenCancelBehaviour.Kill, token);
      }
      catch (OperationCanceledException) { }
      finally
      {

      }
    }
  }
}
