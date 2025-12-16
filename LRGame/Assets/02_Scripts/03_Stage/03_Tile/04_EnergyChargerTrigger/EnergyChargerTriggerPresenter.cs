using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using System;
using System.Threading;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public sealed class EnergyChargerTriggerPresenter : ITriggerTilePresenter
  {
    private const int LineCount = 4;

    public sealed class Model
    {
      public IPlayerGetter PlayerGetter { get; }

      public Model(IPlayerGetter playerGetter)
      {
        PlayerGetter = playerGetter;
      }
    }

    private readonly Model model;
    private readonly EnergyChargerTriggerView view;
    private readonly CTSContainer cts = new();

    private readonly Vector3[] linePositions = new Vector3[LineCount + 1];
    private readonly Vector3[] targetPositions = new Vector3[LineCount + 1];
    private readonly float[] lerpWeights = new float[LineCount + 1];

    public EnergyChargerTriggerPresenter(Model model, EnergyChargerTriggerView view)
    {
      this.model = model;
      this.view = view;

      InitializeWeights();

      view.SubscribeOnEnter(OnEnter);
      view.SubscribeOnExit(OnExit);
    }

    private void InitializeWeights()
    {
      for (int i = 0; i <= LineCount; i++)
        lerpWeights[i] = i;
    }

    public void Enable(bool enable)
    {
      view.gameObject.SetActive(enable);
    }

    public void Restart()
    {
      view.gameObject.SetActive(true);
    }

    private void OnEnter(Collider2D collider)
    {
      if (!collider.CompareTag("Player"))
        return;

      if (!collider.TryGetComponent<IPlayerView>(out var playerView))
        return;

      cts.Cancel();
      cts.Create();

      UpdateLineRendererAsync(collider.transform, cts.token).Forget();

      var player = model.PlayerGetter.GetPlayer(playerView.GetPlayerType());
      player.GetReactionController().SetCharging(true);
    }

    private void OnExit(Collider2D collider)
    {
      if (!collider.CompareTag("Player"))
        return;

      if (!collider.TryGetComponent<IPlayerView>(out var playerView))
        return;

      cts.Cancel();
      ClearLine();

      var player = model.PlayerGetter.GetPlayer(playerView.GetPlayerType());
      player.GetReactionController().SetCharging(false);
    }

    private void ClearLine()
    {
      view.lineRenderer.positionCount = 0;
    }

    private async UniTask UpdateLineRendererAsync(
      Transform target,
      CancellationToken token)
    {
      view.lineRenderer.positionCount = LineCount + 1;

      UpdatePositions(view.transform.position, target.position, linePositions);
      view.lineRenderer.SetPositions(linePositions);

      try
      {
        while (true)
        {
          token.ThrowIfCancellationRequested();

          UpdatePositions(view.transform.position, target.position, targetPositions);

          for (int i = 0; i < LineCount; i++)
          {
            linePositions[i] = Vector3.Lerp(
              linePositions[i],
              targetPositions[i],
              lerpWeights[i] * Time.deltaTime);
          }

          linePositions[LineCount] = targetPositions[LineCount];

          view.lineRenderer.SetPositions(linePositions);
          await UniTask.Yield(PlayerLoopTiming.Update);
        }
      }
      catch (OperationCanceledException) { }
    }

    private static void UpdatePositions(
      Vector3 begin,
      Vector3 end,
      Vector3[] buffer)
    {
      var direction = (end - begin);
      var step = direction / LineCount;

      for (int i = 0; i <= LineCount; i++)
        buffer[i] = begin + step * i;
    }
  }
}
