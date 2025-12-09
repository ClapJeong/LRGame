using UnityEngine;

namespace LR.UI
{
  [RequireComponent(typeof(Animator))]
  public class BaseAnimatorView : MonoBehaviour, IAnimatorView
  {
    private Animator animator;
    private Animator Animator
    {
      get
      {
        if(animator == null)
          animator = GetComponent<Animator>();
        return animator;
      }
    }

    public void Play(int hashID)
      =>Animator.Play(hashID);

    public void SetBool(int hashID, bool value)
      =>Animator.SetBool(hashID, value);

    public void SetFloat(int hashID, float value)
      =>Animator.SetFloat(hashID, value);

    public void SetInt(int hashID, int value)
      =>Animator.SetInteger(hashID, value);

    public void SetTrigger(int hashID)
      =>Animator.SetTrigger(hashID);    
  }
}