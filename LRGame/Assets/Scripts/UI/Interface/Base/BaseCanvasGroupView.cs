using Cysharp.Threading.Tasks;
using UnityEngine;

namespace LR.UI
{
  [RequireComponent(typeof(CanvasGroup))]
  public class BaseCanvasGroupView : MonoBehaviour, ICanvasGroupView
  {
    private CanvasGroup canvasGroup;

    private void OnEnable()
    {
      canvasGroup = GetComponent<CanvasGroup>();
    }

    public virtual void EnableInteractive(bool enable)
      =>canvasGroup.interactable = enable;

    public virtual void EnableRaycast(bool enable)
      =>canvasGroup.blocksRaycasts = enable;

    public virtual void SetAlpha(float alpha)
      =>canvasGroup.alpha = alpha;
  }
}