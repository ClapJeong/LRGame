using UnityEngine;
namespace LR.Stage.SignalListener
{
  public class ACSignalPreview : BaseSignalPreview
  {
    [SerializeField] private SpriteRenderer spriteRenderer;

    public override void Initialize(Vector3 worldPosition)
    {
      transform.position = worldPosition;
      spriteRenderer.SetAlpha(SignalTriggerData.DeactivateAlpha);
    }

    public override void Activate()
    {
      spriteRenderer.SetAlpha(SignalTriggerData.ActivateAlpha);
    }

    public override void Deactivate()
    {
      spriteRenderer.SetAlpha(SignalTriggerData.DeactivateAlpha);
    }
  }
}
