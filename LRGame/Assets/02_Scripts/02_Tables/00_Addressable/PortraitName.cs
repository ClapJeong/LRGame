using UnityEngine;

[System.Serializable]
public class PortraitName
{
  public string GetLeftName(int index)
    => GetLeftName((DialogueDataEnum.Portrait.Left)index);

  public string GetLeftName(DialogueDataEnum.Portrait.Left left)
    => left.ToString() + ".png";

  public string GetRightName(int index)
    => GetRightName((DialogueDataEnum.Portrait.Right)index);

  public string GetRightName(DialogueDataEnum.Portrait.Right right)
    => right.ToString() + ".png";

  public string GetCenterName(int index)
    => GetCenterName((DialogueDataEnum.Portrait.Center)index);

  public string GetCenterName(DialogueDataEnum.Portrait.Center center)
    => center.ToString() + ".png";
}
