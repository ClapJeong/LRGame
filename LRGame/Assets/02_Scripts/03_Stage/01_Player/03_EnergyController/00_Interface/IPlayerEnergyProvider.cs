namespace LR.Stage.Player
{
  public interface IPlayerEnergyProvider
  {
    public bool IsInvincible { get; }

    public bool IsDead { get; }

    public bool IsFull { get; }

    public float CurrentEnergy { get; }
  }
}