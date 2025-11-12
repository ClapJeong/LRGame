using Cysharp.Threading.Tasks;

public interface IStageCreator
{
  public UniTask CreateAsync(bool isEnableImmediately = false);

  public UniTask ReStartAsync();
}
