namespace LR.Stage.Player
{
  public interface IPlayerEnergyUpdater
  {
    public void UpdateEnergy(float deltaTime);

    public void Pause();

    public void Resume();
  }
}