using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage.Effect
{
  public class AnimEffectObject : BaseEffectObject
  {
    [SerializeField] private List<Animator> animators;
    [SerializeField] private float beforeDelay;
    [SerializeField] private float afterDelay;

    private readonly CancellationTokenSource cts = new();

    public override async UniTask PlayAsync(UnityAction onComplete = null, bool autoDestroy = true)
    {
      var token = cts.Token;
      await UniTask.WaitForSeconds(beforeDelay, false, PlayerLoopTiming.Update, token);

      var playHash = EffectTable.AnimEffectTable.PlayHash;
      foreach (var animator in animators)
        animator.Play(playHash);

      await UniTask.NextFrame(token);

      await UniTask.WaitUntil(() =>
      {
        foreach (var animator in animators)
        {
          if (animator == null)
            continue;

          var state = animator.GetCurrentAnimatorStateInfo(0);

          if (!state.shortNameHash.Equals(playHash) ||
              state.normalizedTime < 1.0f)
          {
            return false;
          }
        }
        return true;
      }, cancellationToken: token);

      await UniTask.WaitForSeconds(afterDelay, false, PlayerLoopTiming.Update, token);
      onComplete?.Invoke();
      if (autoDestroy)
        Destroy(gameObject);
    }

    public override void DestoryImmediately()
    {
      cts.Cancel();
    }
  }
}
