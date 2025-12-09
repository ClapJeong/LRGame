using Cysharp.Threading.Tasks;

public interface IStageCreator
{
  public UniTask CreateAsync(int index, bool isEnableImmediately = false);
}
