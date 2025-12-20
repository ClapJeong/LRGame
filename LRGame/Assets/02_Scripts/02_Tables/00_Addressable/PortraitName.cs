using UnityEngine;

[System.Serializable]
public class PortraitName
{
  [SerializeField] private string Null;

  public string GetLeftName(PortraitType.Left left)
  {
    if (left == PortraitType.Left.Null)
      return Null;
    else

    return left.ToString();
  }

  public string GetRightName(PortraitType.Right right)
  {
    if (right == PortraitType.Right.Null)
      return Null;
    else

      return right.ToString();
  }

  public string GetCenterName(PortraitType.Center center)
  {
    if (center == PortraitType.Center.Null)
      return Null;
    else

      return center.ToString();
  }
}
