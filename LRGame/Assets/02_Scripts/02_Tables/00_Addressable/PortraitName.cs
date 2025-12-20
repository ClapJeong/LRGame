using UnityEngine;

[System.Serializable]
public class PortraitName
{
  [SerializeField] private string Null;

  public string GetLeftName(PortraitEnum.Left left)
  {
    if (left == PortraitEnum.Left.Null)
      return Null;
    else

    return left.ToString();
  }

  public string GetRightName(PortraitEnum.Right right)
  {
    if (right == PortraitEnum.Right.Null)
      return Null;
    else

      return right.ToString();
  }

  public string GetCenterName(PortraitEnum.Center center)
  {
    if (center == PortraitEnum.Center.Null)
      return Null;
    else

      return center.ToString();
  }
}
