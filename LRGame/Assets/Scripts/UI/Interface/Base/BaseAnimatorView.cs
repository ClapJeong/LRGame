using UnityEngine;

namespace LR.UI
{
  [RequireComponent(typeof(Animator))]
  public class BaseAnimatorView : MonoBehaviour, IAnimatorView
  {
    private Animator animator;

    public void Play(int hashID)
      =>animator.Play(hashID);

    public void SetBool(int hashID, bool value)
      =>animator.SetBool(hashID, value);

    public void SetFloat(int hashID, float value)
      =>animator.SetFloat(hashID, value);

    public void SetInt(int hashID, int value)
      =>animator.SetInteger(hashID, value);

    public void SetTrigger(int hashID)
      =>animator.SetTrigger(hashID);

    private void OnEnable()
    {
      animator = GetComponent<Animator>();
    }
  }
}