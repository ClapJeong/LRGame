using UnityEngine;
namespace LR.Stage.SignalListener
{
  public class ACSignalPreview : BaseSignalPreview
  {
    [SerializeField] private SpriteRenderer spriteRenderer;

    public override void Initialize(Vector3 worldPosition, Color color)
    {
      transform.position = worldPosition;
      spriteRenderer.color = color;
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

    public override void Restart()
    {
      spriteRenderer.SetAlpha(SignalTriggerData.DeactivateAlpha);
    }
  }
}
