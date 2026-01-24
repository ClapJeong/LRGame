using Cysharp.Threading.Tasks;
using LR.Stage.Player.Enum;

public partial class LocalManager
{
  public void Debugging_StageComplete()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageStateHandler stageStateHandler = StageManager;
    stageStateHandler.Complete();
  }

  public void Debugging_StageLeftFail()
  {
    if (sceneType != SceneType.Game)
      return;

    StageManager
      .GetPlayer(PlayerType.Left)
      .GetReactionController()
      .DamageEnergy(float.MaxValue, ignoreInvincible: true);
  }

  public void Debugging_StageRightFail()
  {
    if (sceneType != SceneType.Game)
      return;

    StageManager
      .GetPlayer(PlayerType.Right)
      .GetReactionController()
      .DamageEnergy(float.MaxValue, ignoreInvincible: true);
  }

  public void Debugging_StageRestart()
  {
    if (sceneType != SceneType.Game)
      return;

    IStageStateHandler stageService = StageManager;
    stageService.RestartAsync().Forget();
  }

  public void Debugging_LeftPlayeEnergyDamaged(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return;

    StageManager
          .GetPlayer(PlayerType.Left)
          .GetReactionController()
          .DamageEnergy(value, true);
  }

  public void Debugging_LeftPlayerEnergyRestored(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return;

    StageManager
      .GetPlayer(PlayerType.Left)
      .GetReactionController()
      .RestoreEnergy(value);
  }

  public void Debugging_RightPlayerEnergyDamaged(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return;

    StageManager
      .GetPlayer(PlayerType.Right)
      .GetReactionController()
      .DamageEnergy(value, true);
  }

  public void Debugging_RightPlayerEnergyRestored(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return;

    StageManager
      .GetPlayer(PlayerType.Right)
      .GetReactionController()
      .RestoreEnergy(value);
  }

  public void Debugging_PlayChatCard(int index)
  {
    var id = (ChatCardEnum.ID)index;
    ChatCardService.PlayChatCardAsync(id).Forget();
  }
}
