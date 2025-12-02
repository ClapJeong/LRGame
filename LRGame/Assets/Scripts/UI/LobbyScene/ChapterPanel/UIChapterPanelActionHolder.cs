using UnityEngine.Events;

namespace LR.UI.Lobby.ChapterPanel
{
  public class UIChapterPanelActionHolder
  {
    private readonly UnityAction onUpPerformed;
    private readonly UnityAction onUpCanceled;
    private readonly UnityAction onRightPerformed;
    private readonly UnityAction onRightCanceled;
    private readonly UnityAction onDownPerformed;
    private readonly UnityAction onDownCanceled;
    private readonly UnityAction onLeftPerformed;
    private readonly UnityAction onLeftCanceled;

    public UIChapterPanelActionHolder(UnityAction onUpPerformed, UnityAction onUpCanceled, UnityAction onRightPerformed, UnityAction onRightCanceled, UnityAction onDownPerformed, UnityAction onDownCanceled, UnityAction onLeftPerformed, UnityAction onLeftCanceled)
    {
      this.onUpPerformed = onUpPerformed;
      this.onUpCanceled = onUpCanceled;
      this.onRightPerformed = onRightPerformed;
      this.onRightCanceled = onRightCanceled;
      this.onDownPerformed = onDownPerformed;
      this.onDownCanceled = onDownCanceled;
      this.onLeftPerformed = onLeftPerformed;
      this.onLeftCanceled = onLeftCanceled;
    }

    public void OnUpPerformed()
      => onUpPerformed?.Invoke();

    public void OnUpCanceled()
      => onUpCanceled?.Invoke();

    public void OnRightPerformed()
      => onRightPerformed?.Invoke();

    public void OnRightCanceled()
      => onRightCanceled?.Invoke();

    public void OnDownPerformed()
      => onDownPerformed?.Invoke();

    public void OnDownCanceled()
      => onDownCanceled?.Invoke();

    public void OnLeftPerformed()
      => onLeftPerformed?.Invoke();

    public void OnLeftCanceled()
      => onLeftCanceled?.Invoke();
  }
}