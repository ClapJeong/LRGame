using UnityEngine;

public interface IChatCardPositionGetter
{
  public Vector2 GetPosition(CharacterPositionType positionType);
}
