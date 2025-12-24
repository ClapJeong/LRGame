using System.Collections.Generic;
using UnityEngine.Events;

public class DialogueService : IDialogueController, IDialogueSubscriber
{
  private readonly Dictionary<IDialogueSubscriber.EventType, UnityEvent> events = new();

  private DialogueState state;

  public DialogueService(IStageEventSubscriber stageEventSubscriber)
  {
    state = DialogueState.None;

    stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.Complete, ()=>
    {
      state = DialogueState.None;
      Play();
    });
  }

  #region IDialogueController
  public void Play()
  {
    if (state != DialogueState.None)
      return;

    events.TryInvoke(IDialogueSubscriber.EventType.OnPlay);
  }

  public void Complete()
  {
    if (state == DialogueState.Complete)
      return;

    events.TryInvoke(IDialogueSubscriber.EventType.OnComplete);
  }

  public void Skip()
  {
    if (state == DialogueState.None)
      return;

    events.TryInvoke(IDialogueSubscriber.EventType.OnSkip);
  }

  public void NextSequence()
  {
    if (state == DialogueState.None)
      return;

    events.TryInvoke(IDialogueSubscriber.EventType.OnNextSequence);
  }

  public void SetState(DialogueState state)
    => this.state = state;
  #endregion

  #region IDialogueSubscriber
  public void SubscribeEvent(IDialogueSubscriber.EventType eventType, UnityAction action)
  {
    events.AddEvent(eventType, action);
  }

  public void UnsubscribeEvent(IDialogueSubscriber.EventType eventType, UnityAction action)
  {
    events.RemoveEvent(eventType, action);
  }
  #endregion
}
