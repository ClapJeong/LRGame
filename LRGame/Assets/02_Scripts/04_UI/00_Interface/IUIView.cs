using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.UI
{
  public interface IUIView: IUIVisibleStateContainer
  {
    public void SubscribeEvent(UIViewEventType eventType, UnityAction action);

    public void UnsubscribeEvent(UIViewEventType eventType, UnityAction action);

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default);

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default);

    public void DestroySelf();
  }
}