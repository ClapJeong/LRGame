public partial class GlobalManager
{
  public void Debugging_AddClearStage()
  => GameDataService.Debugging_RaiseClearData();

  public void Debugging_MinusClearState()
    => GameDataService.Debugging_LowerClearData();

  public void Debugging_ClearClearStage()
    => GameDataService.Debugging_ClearClearData();

  public void Debugging_MaxClearStage()
    => GameDataService.Debugging_MaxClearData();

  public void Debugging_ClearAllConditions()
    => GameDataService.Debugging_ClearAllDialogueConditions();

}
