using UnityEngine;

[System.Serializable]
public class PortraitName
{
  public string GetLeftName(int index)
    => GetLeftName((PortraitEnum.Left)index);

  public string GetLeftName(PortraitEnum.Left left)
    => left.ToString() + ".png";

  public string GetRightName(int index)
    => GetRightName((PortraitEnum.Right)index);

  public string GetRightName(PortraitEnum.Right right)
    => right.ToString() + ".png";

  public string GetCenterName(int index)
    => GetCenterName((PortraitEnum.Center)index);

  public string GetCenterName(PortraitEnum.Center center)
    => center.ToString() + ".png";
}
