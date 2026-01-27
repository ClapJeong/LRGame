using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace LR.Stage.InteractiveObject.AutoMover
{
  public class RepeatMoveController
  {
    private readonly IStageStateProvider stageStateProvider;
    private readonly Transform transform;
    private readonly List<Vector3> waypoints;
    private readonly AnimationCurve animationCurve;
    private readonly Vector3 initializedPosition;
    private float duration;

    private float repeatTime;

    public RepeatMoveController(
      IStageStateProvider stageStateProvider, 
      Transform transform, 
      List<Vector3> waypoints, 
      AnimationCurve animationCurve,
      Vector3 initializedPosition,
      float duration)
    {
      this.stageStateProvider = stageStateProvider;
      this.transform = transform;
      this.waypoints = waypoints;
      this.animationCurve = animationCurve;
      this.initializedPosition = initializedPosition;
      this.duration = duration;      
    }

    public void UpdateDuration(float duration)
    {
      this.duration = duration;
    }

    public async UniTask PlayAsync(CancellationToken token)
    {
      if (waypoints.Count == 0)
        return;

      List<Vector3> points = new() { initializedPosition };
      foreach (var wp in waypoints)
        points.Add(initializedPosition + wp);

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

          repeatTime += Time.deltaTime;
          float t = repeatTime / duration;

          float pingPong = Mathf.PingPong(t, 1f);
          float curveT = animationCurve.Evaluate(pingPong);

          float totalLength = 0f;
          for (int i = 0; i < points.Count - 1; i++)
            totalLength += Vector3.Distance(points[i], points[i + 1]);

          float remain = curveT * totalLength;

          for (int i = 0; i < points.Count - 1; i++)
          {
            float segLen = Vector3.Distance(points[i], points[i + 1]);

            if (remain <= segLen)
            {
              float localT = remain / segLen;
              transform.position = Vector3.Lerp(points[i], points[i + 1], localT);
              break;
            }
            remain -= segLen;
          }

          await UniTask.Yield();
        }
      }
      catch (OperationCanceledException) { }
    }

    public void Reset()
    {
      repeatTime = 0.0f;
    }
  }
}
