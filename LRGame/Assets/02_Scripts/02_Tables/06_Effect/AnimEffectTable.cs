using UnityEngine;

[System.Serializable]
public class AnimEffectTable
{
  private int? playHash = null;
  public int PlayHash
  {
    get
    {
      playHash ??= Animator.StringToHash("Play");

      return playHash.Value;
    }
  }
}
