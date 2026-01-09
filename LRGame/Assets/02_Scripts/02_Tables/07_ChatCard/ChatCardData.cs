[System.Serializable]
public class ChatCardData
{
  public ChatCardEnum.ID id;
  public ChatCardEnum.PortraitType portraitType;
  public string localizeKey;

  public ChatCardData(ChatCardEnum.ID id)
  {
    this.id = id;
  }
}
