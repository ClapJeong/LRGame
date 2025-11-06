using Cysharp.Threading.Tasks;

public interface IStageCreator
{
  public UniTask CreateAsync();

  public UniTask ReStartAsync();
}
