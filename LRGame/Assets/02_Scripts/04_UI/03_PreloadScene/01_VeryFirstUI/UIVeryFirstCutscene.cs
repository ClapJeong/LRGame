using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace LR.UI.Preloading
{
  public class UIVeryFirstCutscene : MonoBehaviour
  {
    [SerializeField] private CanvasGroup canvasGroup;
    [SerializeField] private PlayableDirector director;
    
    public void PlayCutscene(UnityAction onStopped)
    {
      director.stopped += playable=>
      {
        onStopped?.Invoke();
      };
      director.Play();      
    }

    public async UniTask DestroyAsync()
    {
      await DOTween
        .Sequence()
        .Join(canvasGroup.DOFade(0.0f, 0.8f))
        .OnComplete(() => Destroy(gameObject))
        .ToUniTask();
    }
  }
}
