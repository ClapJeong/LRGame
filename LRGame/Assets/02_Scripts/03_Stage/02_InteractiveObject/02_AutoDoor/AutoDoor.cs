using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage.InteractiveObject.AutoMover
{
  public class AutoDoor : BaseInteractiveObject
  {
    [SerializeField] private new Collider2D collider2D;
    [SerializeField] private Animator animator;
    [SerializeField] private bool isOpened = false;

    private readonly CTSContainer cts = new();
    private bool isEnable = true;
    private IStageStateProvider stageStateProvider;

    public override void Initialize(IStageStateProvider stageStateProvider)
    {
      this.stageStateProvider = stageStateProvider;
      InitializeState();
    }

    public override void Enable(bool isEnable)
    {
      this.isEnable = isEnable;
    }    

    public override void Restart()
    {
      cts.Cancel();
      animator.speed = 1.0f;

      InitializeState();
    }

    private void InitializeState()
    {
      if (isOpened)
      {
        animator.Play(AnimatorHash.AutoDoor.Opened);
        collider2D.isTrigger = true;
      }
      else
      {
        animator.Play(AnimatorHash.AutoDoor.Closed);
        collider2D.isTrigger = false;
      }
    }

    public void Open()
    {
      if (!isEnable)
        return;

      cts.Cancel();
      cts.Create();
      var token = cts.token;
      ChangeAsync(
        AnimatorHash.AutoDoor.Openeing,
        token, () =>
        {
          collider2D.isTrigger = true;
        }).Forget();
    }

    public void Close()
    {
      if (!isEnable)
        return;

      cts.Cancel();
      cts.Create();
      var token = cts.token;
      ChangeAsync(
        AnimatorHash.AutoDoor.Closing, 
        token, 
        () =>
        {
          collider2D.isTrigger = false;
        }).Forget();
    }

    private async UniTask ChangeAsync(int targetHash, CancellationToken token, UnityAction onComplete)
    {
      try
      {
        animator.speed = 1.0f;
        animator.Play(targetHash);
        await UniTask.WaitForEndOfFrame();
        
        while (true)
        {
          token.ThrowIfCancellationRequested();
          
          if (animator.GetCurrentAnimatorStateInfo(0).shortNameHash != targetHash)
            break;
          
          UpdateAnimatorSpeed();

          await UniTask.Yield();
        }
        onComplete?.Invoke();
      }
      catch (OperationCanceledException) { }
    }

    private void UpdateAnimatorSpeed()
      => animator.speed = stageStateProvider.GetState() == StageEnum.State.Pause ? 0.0f : 1.0f;
  }
}