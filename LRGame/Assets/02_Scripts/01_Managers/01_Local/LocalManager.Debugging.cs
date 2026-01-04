using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

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

    var leftPlayer = StageManager.GetPlayer(PlayerType.Left);
    leftPlayer.GetEnergyController().Damage(float.MaxValue, ignoreInvincible: true);
  }

  public void Debugging_StageRightFail()
  {
    if (sceneType != SceneType.Game)
      return;

    var rightPlayer = StageManager.GetPlayer(PlayerType.Right);
    rightPlayer.GetEnergyController().Damage(float.MaxValue, ignoreInvincible: true);
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

    var leftPlayer = StageManager.GetPlayer(PlayerType.Left);
    leftPlayer
      .GetEnergyController()
      .Damage(value, true);
  }

  public void Debugging_LeftPlayerEnergyRestored(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return;

    var leftPlayer = StageManager.GetPlayer(PlayerType.Left);
    leftPlayer
      .GetEnergyController()
      .Restore(value);
  }

  public void Debugging_RightPlayerEnergyDamaged(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return;

    var rightPlayer = StageManager.GetPlayer(PlayerType.Right);
    rightPlayer
      .GetEnergyController()
      .Damage(value, true);
  }

  public void Debugging_RightPlayerEnergyRestored(float value)
  {
    if (StageManager.IsAllPlayerExist() == false)
      return;

    var rightPlayer = StageManager.GetPlayer(PlayerType.Right);
    rightPlayer
      .GetEnergyController()
      .Restore(value);
  }

  public void Debugging_PlayChatCard(int index)
  {
    var type = (ChatCardType)index;
    ChatCardService.PlayChatCardAsync(type).Forget();
  }
}
