using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

namespace LR.UI.Preloading
{
  public class UIVeryFirstCutscene : MonoBehaviour
  {
    [SerializeField] private PlayableDirector director;
    
    public void PlayCutscene(UnityAction onStopped)
    {
      director.stopped += playable=>
      {
        onStopped?.Invoke();
      };
      director.Play();      
    }
  }
}
