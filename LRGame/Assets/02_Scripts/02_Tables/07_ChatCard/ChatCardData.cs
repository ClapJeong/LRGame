[System.Serializable]
public class ChatCardData
{
  public ChatCardType type;
  public ChatCardPortraitType portraitType;
  public string key;

  public ChatCardData(ChatCardType type)
  {
    this.type = type;
  }
}
