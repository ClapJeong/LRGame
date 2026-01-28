using Cysharp.Threading.Tasks;
using System;

public interface IChatCardService : IDisposable
{
  public UniTask PlayChatCardAsync(ChatCardEnum.ID id);
}
