using Cysharp.Threading.Tasks;
using DG.Tweening;
using System.Threading;
using UnityEngine;

namespace LR.UI
{
  [RequireComponent(typeof(CanvasGroup))]
  public class BaseCanvasGroupTweenView : MonoBehaviour, ICanvasGroupTweenView
  {
    private CanvasGroup canvasGroup;
    private CanvasGroup CanvasGroup
    {
      get
      {
        if(canvasGroup == null)
          canvasGroup = GetComponent<CanvasGroup>();
        return canvasGroup;
      }
    }

    public async UniTask DoFadeAsync(float alpha, float duration, CancellationToken token = default)
    {
      await CanvasGroup.DOFade(alpha, duration).ToUniTask(tweenCancelBehaviour: TweenCancelBehaviour.Kill, token);
    }
  }
}