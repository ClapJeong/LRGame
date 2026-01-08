using Cysharp.Threading.Tasks;

public interface IChatCardService
{
  public UniTask PlayChatCardAsync(ChatCardEnum.ID id);
}
