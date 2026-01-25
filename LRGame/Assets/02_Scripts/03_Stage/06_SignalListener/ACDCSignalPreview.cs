using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.Stage.SignalListener
{
  public class ACDCSignalPreview :  BaseSignalPreview
  {
    [SerializeField] private SpriteRenderer spriteRenderer;

    private IDisposable rotateDisposable;

    public override void Initialize(Vector3 worldPosition, Color color)
    {
      transform.position = worldPosition;
      spriteRenderer.color = color;
      spriteRenderer.SetAlpha(SignalTriggerData.DeactivateAlpha);
    }

    public override void Activate()
    {
      spriteRenderer.SetAlpha(SignalTriggerData.ActivateAlpha);
      rotateDisposable = gameObject
        .UpdateAsObservable()
        .Subscribe(_ =>
        {
          transform.Rotate(-360.0f * Time.deltaTime * SignalTriggerData.RotateSpeed * Vector3.forward);
        });
    }

    public override void Deactivate()
    {
      spriteRenderer.SetAlpha(SignalTriggerData.DeactivateAlpha);
      rotateDisposable?.Dispose();
      transform.eulerAngles = Vector3.zero;      
    }

    private void OnDestroy()
    {
      rotateDisposable?.Dispose();      
    }
  }
}
