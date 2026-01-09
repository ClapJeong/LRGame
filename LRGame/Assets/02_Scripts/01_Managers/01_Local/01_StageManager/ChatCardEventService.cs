using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using LR.Stage.StageDataContainer;
using System;
using System.Collections.Generic;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using static ChatCardEnum;

public class ChatCardEventService
{
  private class TimeCheckSet
  {
    public int index;
    public ChatCardEventSet data;
    public bool called = false;

    public TimeCheckSet(int index, ChatCardEventSet data)
    {
      this.index = index;
      this.data = data;
    }
  }

  private readonly GameObject disposeAttachTarget;
  private readonly IChatCardService chatCardService;

  private readonly IStageEventSubscriber stageEventSubscriber;
  private readonly IStageStateProvider stageStateProvider;  
  private readonly ITriggerTileEventSubscriber triggerTileEventSubscriber;
  private readonly ISignalSubscriber signalSubscriber;

  private readonly CTSContainer delayCTS = new();
  private readonly CTSContainer stageTimeCTS = new();
  private readonly Dictionary<int, bool> chatCardPlayable = new();
  private readonly List<TimeCheckSet> timeCheckSets = new();

  public ChatCardEventService(GameObject disposeAttachTarget, IChatCardService chatCardService, IStageEventSubscriber stageEventSubscriber, IStageStateProvider stageStateProvider, ITriggerTileEventSubscriber triggerTileEventSubscriber, ISignalSubscriber signalSubscriber)
  {
    this.disposeAttachTarget = disposeAttachTarget;
    this.chatCardService = chatCardService;
    this.stageEventSubscriber = stageEventSubscriber;
    this.stageStateProvider = stageStateProvider;
    this.triggerTileEventSubscriber = triggerTileEventSubscriber;
    this.signalSubscriber = signalSubscriber;
  }

  public void SetupChatCardEvents(
    IPlayerPresenter leftPlayerPresenter, 
    IPlayerPresenter rightPlayerPresenter,
    List<ChatCardEventSet> eventSets)
  {
    for (int i = 0; i < eventSets.Count; i++)
    {
      var index = i;
      chatCardPlayable[index] = true;
      var eventSet = eventSets[i];
      switch (eventSet.eventType)
      {
        case ChatCardEnum.EventType.Stage:
          {
            var data = eventSet.stageEventData;
            switch (data.stageEventType)
            {
              case StageEventType.OnAfterBeginTime:
                timeCheckSets.Add(new(index, eventSet));
                break;

              case StageEventType.OnFail:
                stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.AllExhausted, PlayChatCard);
                break;

              case StageEventType.OnComplete:
                stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.Complete, PlayChatCard);
                break;

              case StageEventType.OnRestart:
                stageEventSubscriber.SubscribeOnEvent(IStageEventSubscriber.StageEventType.Restart, PlayChatCard);
                break;
            }
          }
          break;

        case ChatCardEnum.EventType.Player:
          {
            var data = eventSet.playerEventData;
            switch (data.playerEventType)
            {
              case PlayerEventType.OnEnergyChanged:
                {
                  var playerEnergySubscriber = data.targetPlayerType switch
                  {
                    PlayerType.Left => leftPlayerPresenter.GetEnergySubscriber(),
                    PlayerType.Right => rightPlayerPresenter.GetEnergySubscriber(),
                    _ => throw new NotImplementedException()
                  };

                  playerEnergySubscriber.SubscribeOnChanged(data.valueType, data.targetNormalizedValue, PlayChatCard);
                }
                break;

              case PlayerEventType.OnStateChanged:
                {
                  var playerStateSubscriber = data.targetPlayerType switch
                  {
                    PlayerType.Left => leftPlayerPresenter.GetStateSubscriber(),
                    PlayerType.Right => rightPlayerPresenter.GetStateSubscriber(),
                    _ => throw new NotImplementedException()
                  };

                  if (data.enter)
                    playerStateSubscriber.SubscribeOnEnter(data.targetPlayerState, PlayChatCard);
                }
                break;
            }
          }
          break;

        case ChatCardEnum.EventType.Trigger:
          {
            var data = eventSet.triggerTileEventData;
            switch (data.triggerEventType)
            {
              case TriggerEventType.OnEnter:
                triggerTileEventSubscriber.SubscribeOnEnter(data.targetPlayerType, data.targetTriggerTileType, PlayChatCard);
                break;

              case TriggerEventType.OnExit:
                triggerTileEventSubscriber.SubscribeOnExit(data.targetPlayerType, data.targetTriggerTileType, PlayChatCard);
                break;
            }
          }
          break;

        case ChatCardEnum.EventType.Signal:
          {
            var data = eventSet.signalEventData;
            if (string.IsNullOrEmpty(data.targetKey))
              Debug.LogError($"{eventSet.id} 호출하는 SignalKey 비어있음!");

            switch (data.signalEventType)
            {
              case SignalEventType.OnActivate:
                signalSubscriber.SubscribeActivate(data.targetKey, PlayChatCard);
                break;

              case SignalEventType.OnDeactivate:
                signalSubscriber.SubscribeDeactivate(data.targetKey, PlayChatCard);
                break;
            }
          }
          break;
      }

      void PlayChatCard()
      {
        PlayChatCardAsync(index, eventSet, delayCTS.token).Forget();
      }
    }

    if (timeCheckSets.Count > 0)
      CheckStageTimeAsync(stageTimeCTS.token).Forget();

    disposeAttachTarget
      .OnDestroyAsObservable()
      .Subscribe(_ =>
      {
        delayCTS.Cancel();
        stageTimeCTS.Cancel();
      });
  }

  private async UniTask CheckStageTimeAsync(CancellationToken token)
  {
    try
    {
      var time = 0.0f;
      while (true)
      {
        token.ThrowIfCancellationRequested();

        if (stageStateProvider.GetState() != StageEnum.State.Playing)
        {
          await UniTask.Yield();
          continue;
        }

        foreach (var timeCheckSet in timeCheckSets)
        {
          if (timeCheckSet.called)
            continue;

          var targetTime = timeCheckSet.data.stageEventData.time;
          if (time >= targetTime)
          {
            PlayChatCardAsync(timeCheckSet.index, timeCheckSet.data, delayCTS.token).Forget();
            timeCheckSet.called = true;
          }
        }

        time += Time.deltaTime;
        await UniTask.Yield();
      }
    }
    catch (OperationCanceledException) { }
  }

  private async UniTask PlayChatCardAsync(int index, ChatCardEventSet data, CancellationToken token)
  {
    if (chatCardPlayable[index])
    {
      try
      {
        if(data.delay > 0.0f)
        {
          var duration = 0.0f;
          while (duration < data.delay)
          {
            token.ThrowIfCancellationRequested();

            if(stageStateProvider.GetState() != StageEnum.State.Playing)
            {
              await UniTask.Yield();
              continue;
            }

            duration += Time.deltaTime;
            await UniTask.Yield();
          }
        }          

        chatCardService.PlayChatCardAsync(data.id).Forget();
      }
      catch (OperationCanceledException) { }
    }
      
    if(data.playOnce)
      chatCardPlayable[index] = false;
  }

  public void Reset()
  {
    stageTimeCTS.Cancel();
    stageTimeCTS.Create();

    delayCTS.Cancel();
    delayCTS.Create();

    for (int i = 0; i < chatCardPlayable.Count; i++)
      chatCardPlayable[i] = true;
    foreach (var timeCheckSet in timeCheckSets)
      timeCheckSet.called = false;

    if (timeCheckSets.Count > 0)
      CheckStageTimeAsync(stageTimeCTS.token).Forget();

  }
}
