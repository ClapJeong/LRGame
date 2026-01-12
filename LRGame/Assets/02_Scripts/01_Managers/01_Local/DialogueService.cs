using System.Collections.Generic;
using UnityEngine.Events;

public class DialogueService : IDialogueStateController, IDialogueStateSubscriber
{
  private readonly Dictionary<IDialogueStateSubscriber.EventType, UnityEvent> events = new();

  private SequenceState state;

  public DialogueService(IStageEventSubscriber stageEventSubscriber)
  {
    state = SequenceState.WaitingForPlay;

    stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.Complete, Play);
  }

  #region IDialogueController
  public void Play()
  {
    events.TryInvoke(IDialogueStateSubscriber.EventType.OnPlay);
  }

  public void Complete()
  {
    if (state == SequenceState.Complete)
      return;

    events.TryInvoke(IDialogueStateSubscriber.EventType.OnComplete);

    state = SequenceState.WaitingForPlay;
  }

  public void Skip()
  {
    if (state == SequenceState.WaitingForPlay)
      return;

    events.TryInvoke(IDialogueStateSubscriber.EventType.OnSkip);
  }

  public void NextSequence()
  {
    if (state == SequenceState.WaitingForPlay)
      return;

    events.TryInvoke(IDialogueStateSubscriber.EventType.OnNextSequence);
  }

  public void SetSequenceState(SequenceState state)
    => this.state = state;
  #endregion

  #region IDialogueSubscriber
  public void SubscribeEvent(IDialogueStateSubscriber.EventType eventType, UnityAction action)
  {
    events.AddEvent(eventType, action);
  }

  public void UnsubscribeEvent(IDialogueStateSubscriber.EventType eventType, UnityAction action)
  {
    events.RemoveEvent(eventType, action);
  }
  #endregion
}
