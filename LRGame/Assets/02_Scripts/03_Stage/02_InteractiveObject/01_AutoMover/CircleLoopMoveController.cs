using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;

namespace LR.Stage.InteractiveObject.AutoMover
{
  public class CircleLoopMoveController
  {
    private readonly IStageStateProvider stageStateProvider; 
    private readonly Transform transform;
    private readonly AnimationCurve animationCurve;
    private readonly float radius;
    private readonly Vector3 circleCenter;
    private float duration;
    
    private float circleTime;
    private float circleAngleRad = 0f;

    public CircleLoopMoveController(IStageStateProvider stageStateProvider, Transform transform, AnimationCurve animationCurve, float radius, float duration, Vector3 circleCenter)
    {
      this.stageStateProvider = stageStateProvider;
      this.transform = transform;
      this.animationCurve = animationCurve;
      this.radius = radius;
      this.duration = duration;
      this.circleCenter = circleCenter;
    }

    public void UpdateDuration(float duration)
    {
      this.duration = duration;
    }

    public async UniTask PlayAsync(CancellationToken token)
    {
      try
      {
        while (true)
        {
          token.ThrowIfCancellationRequested();

          if (stageStateProvider.GetState() != StageEnum.State.Playing)
          {
            await UniTask.Yield();
            continue;
          }

          float prevT = Mathf.Repeat(circleTime / duration, 1f);
          float prevCurve = animationCurve.Evaluate(prevT);

          circleTime += Time.deltaTime;

          float currT = Mathf.Repeat(circleTime / duration, 1f);
          float currCurve = animationCurve.Evaluate(currT);

          float deltaCurve = currCurve - prevCurve;

          // 한 바퀴(2π)에 대한 위치 변화량
          float angleDelta = deltaCurve * Mathf.PI * 2f;

          circleAngleRad -= angleDelta; // 시계 방향

          Vector3 offset = new Vector3(
            Mathf.Cos(circleAngleRad),
            Mathf.Sin(circleAngleRad),
            0f
          ) * radius;

          transform.position = circleCenter + offset;

          await UniTask.Yield();
        }
      }
      catch (OperationCanceledException) { }
    }

    public void Reset()
    {
      circleTime = 0.0f;
      circleAngleRad = 0.0f;
    }
  }
}
