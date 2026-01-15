using LR.Stage.Player;
using LR.Stage.StageDataContainer;

public class ScoreCalculator
{

  public void CalculateScore(
    ScoreData scoreData, 
    IPlayerPresenter leftPlayer, 
    IPlayerPresenter rightPlayer,
    out bool leftScore,
    out bool rightScore)
  {
    leftScore = scoreData.Left <= leftPlayer.GetEnergyProvider().CurrentNormalized;
    rightScore = scoreData.Right <= rightPlayer.GetEnergyProvider().CurrentNormalized;
  }
}
