using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace LR.UI
{
  public class BaseSubmitView : MonoBehaviour, ISubmitView
  {
    private readonly UnityEvent onSubmit = new();
    private bool isEnable = true;

    public void Enable(bool enabled)
      => isEnable = enabled;

    public bool GetEnable()
      => isEnable;

    public void OnSubmit(BaseEventData eventData)
    {
      onSubmit.Invoke();
    }

    public void SubscribeOnSubmit(UnityAction onSubmit)
    {
      this.onSubmit.AddListener(onSubmit);
    }

    public void UnsubscribeOnSubmit(UnityAction onSubmit)
    {
      this.onSubmit.RemoveListener(onSubmit);
    }
  }
}