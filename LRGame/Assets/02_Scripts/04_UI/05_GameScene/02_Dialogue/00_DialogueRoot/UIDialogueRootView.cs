using Cysharp.Threading.Tasks;
using System.Threading;

namespace LR.UI.GameScene.Dialogue
{
  public class UIDialogueRootView : BaseUIView
  {
    public UIDialogueCharacterView leftView;
    public UIDialogueCharacterView centerView;
    public UIDialogueCharacterView rightView;
    public UIDialogueInputsView inputView;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}
