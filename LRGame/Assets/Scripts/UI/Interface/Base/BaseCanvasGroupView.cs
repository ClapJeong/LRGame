using Cysharp.Threading.Tasks;
using UnityEngine;

namespace LR.UI
{
  [RequireComponent(typeof(CanvasGroup))]
  public class BaseCanvasGroupView : MonoBehaviour, ICanvasGroupView
  {
    private CanvasGroup canvasGroup;
    private CanvasGroup CanvasGroup
    {
      get
      {
        if (canvasGroup == null)
          canvasGroup = GetComponent<CanvasGroup>();
        return canvasGroup;
      }
    }

    public virtual void EnableInteractive(bool enable)
      =>CanvasGroup.interactable = enable;

    public virtual void EnableRaycast(bool enable)
      =>CanvasGroup.blocksRaycasts = enable;

    public virtual void SetAlpha(float alpha)
      =>CanvasGroup.alpha = alpha;
  }
}