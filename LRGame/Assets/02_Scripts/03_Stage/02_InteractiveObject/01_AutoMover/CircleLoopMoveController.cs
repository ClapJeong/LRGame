using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;

namespace LR.Stage.InteractiveObject.AutoMover
{
  public class CircleLoopMoveController
  {
    private readonly IStageStateProvider stageStateProvider; 
    private readonly Transform transform;
    private readonly AnimationCurve animationCurve;
    private readonly Vector2 initializePosition;
    private readonly float radius;
    private readonly Vector3 circleCenter;    
    private float duration;

    private readonly float beginRad;

    private float normalizedTime;
    private float circleAngleRad;

    public CircleLoopMoveController(
      IStageStateProvider stageStateProvider, 
      Transform transform, 
      AnimationCurve animationCurve, 
      Vector2 initializePosition,
      float radius, 
      float duration, 
      Vector3 circleCenter, 
      float beginAngle)
    {
      this.stageStateProvider = stageStateProvider;
      this.transform = transform;
      this.animationCurve = animationCurve;
      this.initializePosition = initializePosition;
      this.radius = radius;
      this.duration = duration;
      this.circleCenter = circleCenter;

      beginRad = beginAngle * Mathf.Deg2Rad;
      normalizedTime = 0f;
      circleAngleRad = 0.0f;
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

          float prevT = normalizedTime;
          float prevCurve = animationCurve.Evaluate(prevT);

          normalizedTime += Time.deltaTime / duration;
          normalizedTime = Mathf.Repeat(normalizedTime, 1f);

          float currCurve = animationCurve.Evaluate(normalizedTime);
          float deltaCurve = currCurve - prevCurve;

          float angleDelta = deltaCurve * Mathf.PI * 2f;

          // 시작 각도 + curve 위치
          circleAngleRad -= angleDelta;

          float finalAngle = beginRad + circleAngleRad;

          Vector3 offset = new Vector3(
            Mathf.Cos(finalAngle),
            Mathf.Sin(finalAngle),
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
      normalizedTime = 0f;
      circleAngleRad = 0f;
    }
  }
}
