using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace LR.Stage.Effect
{
  public class ParticleEffectObject : BaseEffectObject
  {
    [SerializeField] private List<ParticleSystem> particles;
    [SerializeField] private float beforeDelay;
    [SerializeField] private float afterDelay;
    private readonly CancellationTokenSource cts = new();

    public override async UniTask PlayAsync(UnityAction onComplete = null, bool autoDestroy = true)
    {
      var token = cts.Token;

      await UniTask.WaitForSeconds(beforeDelay, false, PlayerLoopTiming.Update, token);

      foreach (var particle in particles)
        particle.Play();

      await UniTask.WaitUntil(() =>
      {
        foreach (var particle in particles)
          if (particle.IsAlive())
            return false;

        return true;
      }, PlayerLoopTiming.Update, token);

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
