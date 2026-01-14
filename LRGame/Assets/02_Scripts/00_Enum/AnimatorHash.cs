using UnityEngine;

public static class AnimatorHash
{
  public static class ClearTriggerTile
  {
    public static class Clip
    {
      public static readonly int LeftEnter = Animator.StringToHash(nameof(LeftEnter));
      public static readonly int RightEnter = Animator.StringToHash(nameof(RightEnter));
      public static readonly int Idle = Animator.StringToHash(nameof(Idle));
    }    
  }

  public static class Player
  {
    public static class Parameter
    {
      public static readonly int Horizontal = Animator.StringToHash(nameof(Horizontal));
      public static readonly int Vertical = Animator.StringToHash(nameof(Vertical));
    }    

    public static class Clip
    {
      public static readonly int Idle = Animator.StringToHash(nameof(Idle));
      public static readonly int MoveBlend = Animator.StringToHash(nameof(MoveBlend));
      public static readonly int Bounced = Animator.StringToHash(nameof(Bounced));
      public static readonly int Inputing = Animator.StringToHash(nameof(Inputing));
      public static readonly int Stun = Animator.StringToHash(nameof(Stun));
    }
  }
}
