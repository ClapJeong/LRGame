using Cysharp.Threading.Tasks;

public interface IChatCardService
{
  public UniTask PlayChatCardAsync(ChatCardType type);
}
