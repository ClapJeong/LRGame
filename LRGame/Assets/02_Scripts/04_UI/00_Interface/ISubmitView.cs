using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace LR.UI
{
  public interface ISubmitView : ISubmitHandler
  {
    public void Enable(bool enabled);

    public bool GetEnable();

    public void SubscribeOnSubmit(UnityAction onSubmit);

    public void UnsubscribeOnSubmit(UnityAction onSubmit);
  }
}