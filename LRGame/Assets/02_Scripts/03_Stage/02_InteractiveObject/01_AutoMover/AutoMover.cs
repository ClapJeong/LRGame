using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

namespace LR.Stage.InteractiveObject.AutoMover
{
  public class AutoMover : BaseInteractiveObject
  {
    public enum Type
    {
      Straight,
      Repeat,
      CircleLoop,
    }

    public Type type;
    [SerializeField] private AnimationCurve animationCurve = AnimationCurve.EaseInOut(0.0f,0.0f,1.0f,1.0f);
    [SerializeField] private bool startOnAwake;
    [SerializeField] private float duration = 1.0f;
    [SerializeField] private List<Vector3> waypoints = new();
    [SerializeField] private float radius = 1.0f;
    [SerializeField] private float angle = 0.0f;
    
    private StraightMoveController straightMoveController;
    private RepeatMoveController repeatMoveController;
    private CircleLoopMoveController circleLoopMoveController;

    private readonly CTSContainer cts = new();
    private Vector3 circleCenter;
    private Vector3 initializePosition;

    private void OnValidate()
    {
      if (duration <= 0.0f)
        duration = 0.1f;

      straightMoveController?.UpdateDuration(duration);
      repeatMoveController?.UpdateDuration(duration);
      circleLoopMoveController?.UpdateDuration(duration);
    }

    public override void Initialize(IStageStateProvider stageStateProvider)
    {
      initializePosition = transform.position;
      circleCenter = transform.TransformPoint(new Vector2(Mathf.Sin(Mathf.Deg2Rad * angle), Mathf.Cos(Mathf.Deg2Rad * angle)) * radius);

      straightMoveController = new(stageStateProvider, transform, waypoints, animationCurve, duration);
      repeatMoveController = new(stageStateProvider, transform, waypoints, animationCurve, duration);
      circleLoopMoveController = new(stageStateProvider, transform, animationCurve, radius, duration, circleCenter);
    }

    public void ActivateMove()
    {
      cts.Dispose();
      cts.Create();
      switch (type)
      {
        case Type.Straight:
          straightMoveController.PlayAsync(cts.token).Forget();
          break;

        case Type.Repeat:
          repeatMoveController.PlayAsync(cts.token).Forget();
          break;

        case Type.CircleLoop:
          circleLoopMoveController.PlayAsync(cts.token).Forget();
          break;
      }
    }

    public void DeactivateMove()
    {
      cts.Cancel();
    }


    private void OnDrawGizmos()
    {
      switch (type)
      {
        case Type.Straight:
          {
            DrawPositionsLine(false);
          }
          break;

        case Type.Repeat:
          {
            DrawPositionsLine(false);
          }
          break;

        case Type.CircleLoop:
          {
            var currentCircleCenter = transform.TransformPoint(new Vector2(Mathf.Sin(Mathf.Deg2Rad * angle), Mathf.Cos(Mathf.Deg2Rad * angle)) * radius);
            DrawCircleLines(currentCircleCenter, radius);
          }
          break;
      }
    }

    private void DrawPositionsLine(bool isLoop)
    {
      Gizmos.color = Color.red;
      var positionList = new List<Vector3>() { transform.position };
      foreach (var position in waypoints)
        positionList.Add(transform.TransformPoint(position));
      Gizmos.DrawLineStrip(new System.ReadOnlySpan<Vector3>(positionList.ToArray()), isLoop);
    }

    private void DrawCircleLines(Vector3 center, float radius, int segments = 32)
    {
      Gizmos.color = Color.red;
      Vector3 prevPoint = center + Vector3.right * radius;

      for (int i = 1; i <= segments; i++)
      {
        float angle = i * Mathf.PI * 2f / segments;
        Vector3 newPoint = center + new Vector3(
            Mathf.Cos(angle),
            Mathf.Sin(angle),
            0f            
        ) * radius;

        Gizmos.DrawLine(prevPoint, newPoint);
        prevPoint = newPoint;
      }
    }

    public override void Enable(bool enable)
    {
      if (enable && startOnAwake)
        ActivateMove();
      else if (!enable)
        DeactivateMove();
    }

    public override void Restart()
    {
      Enable(false);
      straightMoveController.Reset();
      repeatMoveController.Reset();
      circleLoopMoveController.Reset();
      transform.position = initializePosition;
      Enable(true);
    }
  }
}
