using System.Collections.Generic;
using UnityEngine.Events;

namespace LR.UI
{
  public interface IUIProgressSubmitView
  {
    public void Enable(bool isEnable);

    public bool IsEnable(); 

    public void Perform(Direction direction);

    public void Cancel(Direction direction);

    public void SubscribeOnPerformed(Direction direction, UnityAction onPerformed);

    public void SubscribeOnCanceled(Direction direction, UnityAction onCanceled);

    public void SubscribeOnProgress(Direction direction, UnityAction<float> onProgress);

    public void SubscribeOnComplete(Direction direction, UnityAction onComplete);

    public void UnsubscribeOnPerformed(Direction direction, UnityAction onPerformed);

    public void UnsubscribeOnCanceled(Direction direction, UnityAction onCanceled);

    public void UnsubscribeOnProgress(Direction direction, UnityAction<float> onProgress);

    public void UnsubscribeOnComplete(Direction direction, UnityAction onComplete);

    public void SubscribeOnPerformed(List<Direction> directions, UnityAction onPerformed);

    public void SubscribeOnCanceled(List<Direction> directions, UnityAction onCanceled);

    public void SubscribeOnProgress(List<Direction> directions, UnityAction<float> onProgress);

    public void SubscribeOnComplete(List<Direction> directions, UnityAction onComplete);

    public void UnsubscribeOnPerformed(List<Direction> directions, UnityAction onPerformed);

    public void UnsubscribeOnCanceled(List<Direction> directions, UnityAction onCanceled);

    public void UnsubscribeOnProgress(List<Direction> directions, UnityAction<float> onProgress);

    public void UnsubscribeOnComplete(List<Direction> directions, UnityAction onComplete);

    public void UnsubscribeAll();

    public void ResetProgress(Direction direction);

    public void ResetAllProgress();
  }
}