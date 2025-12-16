using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using System;
using System.Threading;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class EnergyChargerTriggerPresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public IPlayerGetter playerGetter;

      public Model(IPlayerGetter playerGetter)
      {
        this.playerGetter = playerGetter;
      }
    }

    private static int LineCount = 4;

    private readonly Model model;
    private readonly EnergyChargerTriggerView view;
    private readonly CTSContainer cts = new();

    private Vector3[] lineRendererPositions = new Vector3[LineCount + 1];

    public EnergyChargerTriggerPresenter(Model model, EnergyChargerTriggerView view)
    {
      this.model = model;
      this.view = view;

      view.SubscribeOnEnter(OnEnter);
      view.SubscribeOnExit(OnExit);
    }

    public void Enable(bool enable)
    {
      view.gameObject.SetActive(enable);
    }

    public void Restart()
    {
      view.gameObject.SetActive(true);
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (collider2D.CompareTag("Player") == false)
        return;

      cts.Create();
      UpdateLineRendererAsync(collider2D.transform, cts.token).Forget();

      var playerType = collider2D.GetComponent<IPlayerView>().GetPlayerType();
      model
        .playerGetter
        .GetPlayer(playerType)
        .GetReactionController()
        .SetCharging(true);
    }

    private void OnExit(Collider2D collider2D)
    {
      if (collider2D.CompareTag("Player") == false)
        return;

      cts.Cancel();
      view.lineRenderer.positionCount = 0;

      var playerType = collider2D.GetComponent<IPlayerView>().GetPlayerType();
      model
        .playerGetter
        .GetPlayer(playerType)
        .GetReactionController()
        .SetCharging(false);
    }

    private async UniTask UpdateLineRendererAsync(Transform targetTransform, CancellationToken token)
    {      
      lineRendererPositions = GetLinePositions(view.transform.position, targetTransform.position);
      view.lineRenderer.positionCount = LineCount + 1;
      view.lineRenderer.SetPositions(lineRendererPositions);
      var currentPositions = new Vector3[LineCount + 1];

      var lerpValue = new float[LineCount + 1];
      for (int i = 0; i < LineCount + 1; i++)
        lerpValue[i] = 1.0f * i;

      try
      {
        while (true)
        {
          token.ThrowIfCancellationRequested();

          currentPositions = GetLinePositions(view.transform.position, targetTransform.position);
          for(int i = 0; i < LineCount + 1; i++)
            lineRendererPositions[i] = Vector3.Lerp(lineRendererPositions[i], currentPositions[i], lerpValue[i] * Time.deltaTime);
          lineRendererPositions[LineCount] = currentPositions[LineCount];

          view.lineRenderer.SetPositions(lineRendererPositions);
          await UniTask.Yield(PlayerLoopTiming.Update);
        }
      }
      catch (OperationCanceledException) { }
    }

    private Vector3[] GetLinePositions(Vector3 beginPosition, Vector3 endPosition)
    {
      var result = new Vector3[LineCount + 1];

      var length = Vector3.Distance(beginPosition, endPosition) / ((float)LineCount);
      var direction = (endPosition - beginPosition).normalized;

      for(int i = 0; i < LineCount + 1; i++)
        result[i] = beginPosition + direction * length * i;

      return result;
    }
  }
}