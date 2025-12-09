using UnityEngine;

namespace LR.UI
{
  public interface IAnimatorView
  {
    public void SetBool(int hashID, bool value);

    public void SetFloat(int hashID, float value);

    public void SetInt(int hashID, int value);

    public void SetTrigger(int hashID);

    public void Play(int hashID);
  }
}