using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace LR.Stage.InteractiveObject.AutoMover
{
  public class StraightMoveController
  {
    private readonly IStageStateProvider stageStateProvider; 
    private readonly Transform transform;
    private readonly List<Vector3> waypoints;
    private readonly AnimationCurve animationCurve;
    private readonly Vector3 initializedPosition;
    private float duration;

    private float straightTime;

    private int straightIndex = 0;
    private float segmentT = 0f;

    private bool straightFinished = false;

    public StraightMoveController(
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
      if (straightFinished || waypoints.Count == 0)
        return;

      try
      {
        Vector3 from = initializedPosition;

        for (; straightIndex < waypoints.Count; straightIndex++)
        {
          Vector3 to = from + waypoints[straightIndex];

          while (segmentT < 1f)
          {
            token.ThrowIfCancellationRequested();

            if(stageStateProvider.GetState() != StageEnum.State.Playing)
            {
              await UniTask.Yield();
              continue;
            }

            straightTime += Time.deltaTime;
            segmentT = Mathf.Clamp01(straightTime / duration);

            float evalT = animationCurve.Evaluate(segmentT);
            transform.position = Vector3.Lerp(from, to, evalT);

            await UniTask.Yield();
          }

          from = to;
          straightTime = 0f;
          segmentT = 0f;
        }

        straightFinished = true;
      }
      catch (OperationCanceledException) { }
    }

    public void Reset()
    {
      straightTime = 0.0f;
      straightIndex = 0;
      segmentT = 0.0f;
      straightFinished = false;
    }
  }
}
