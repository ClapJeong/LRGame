using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine.Events;
using LR.Stage.Player;
using LR.Stage.TriggerTile;
using LR.Stage;

public class StageManager : IStageService, IStageCreator
{
  public class Model
  {
    public IResourceManager resourceManager;
    public ISceneProvider sceneProvider;
    public ICameraService cameraService;

    public Model(IResourceManager resourceManager, ISceneProvider sceneProvider, ICameraService cameraService)
    {
      this.resourceManager = resourceManager;
      this.sceneProvider = sceneProvider;
      this.cameraService = cameraService;
    }
  }

  private readonly Model model;

  private readonly PlayerService playerSetupService;
  private readonly TriggerTileService triggerTileSetupService;

  private readonly Dictionary<IStageService.StageEventType, UnityEvent> stageEvents = new();  

  private IStageService.State stageState = IStageService.State.Ready;
  private bool isLeftExhausted = false;
  private bool isRightExhausted = false;

  public StageManager(Model model)
  {
    this.model = model;

    playerSetupService = new PlayerService(stageService: this);
    triggerTileSetupService = new TriggerTileService();
  }

  #region IStageCreator
  public async UniTask CreateAsync(int index, bool isEnableImmediately = false)
  {
    var table = GlobalManager.instance.Table.AddressableKeySO;
    var key = table.Path.Stage + string.Format(table.StageName.StageNameFormat, index);
    try
    {
      var stageDataContainer = await model.resourceManager.CreateAssetAsync<StageDataContainer>(key);

      SetupCamera(stageDataContainer);
      SetupPlayers(stageDataContainer);
      SetupTriggers(stageDataContainer);
      SetupDynamicObstacles(stageDataContainer);

      SetState(IStageService.State.Ready);
    }
    catch
    {
      GlobalManager.instance.GameDataService.SetSelectedStage(-1, -1);
      model.sceneProvider.LoadSceneAsync(SceneType.Lobby).Forget();
    }
  }
  #endregion

  #region IStageService
  public UniTask RestartAsync()
  {
    playerSetupService.RestartAll();
    triggerTileSetupService.RestartAll();

    SetState(IStageService.State.Playing);
    return UniTask.CompletedTask;
  }

  public void Complete()
  {
    stageEvents.TryInvoke(IStageService.StageEventType.Complete);

    IStageObjectControlService<IPlayerPresenter> playerController = playerSetupService;
    IStageObjectControlService<ITriggerTilePresenter> triggerTileController = triggerTileSetupService;
    playerController.EnableAll(false);
    triggerTileController.EnableAll(false);
    SetState(IStageService.State.Success);
  }

  public void Begin()
  {
    stageEvents.TryInvoke(IStageService.StageEventType.Begin);

    playerSetupService.EnableAll(true);
    triggerTileSetupService.EnableAll(true);
    SetState(IStageService.State.Playing);
  }

  public void Pause()
  {
    stageEvents.TryInvoke(IStageService.StageEventType.Pause);

    playerSetupService.EnableAll(false);
    triggerTileSetupService.EnableAll(false);
    SetState(IStageService.State.Pause);
  }

  public void Resume()
  {
    stageEvents.TryInvoke(IStageService.StageEventType.Resume);

    playerSetupService.EnableAll(true);
    triggerTileSetupService.EnableAll(true);
    SetState(IStageService.State.Playing);
  }

  public void OnLeftExhausted()
  {
    stageEvents.TryInvoke(IStageService.StageEventType.LeftExhausted);

    isLeftExhausted = true;

    if(isLeftExhausted && isRightExhausted)
      stageEvents.TryInvoke(IStageService.StageEventType.AllExhausted);
  }

  public void OnLeftRevived()
  {
    stageEvents.TryInvoke(IStageService.StageEventType.LeftRevived);

    isLeftExhausted = false;
  }

  public void OnRightExhaused()
  {
    stageEvents.TryInvoke(IStageService.StageEventType.RightExhausted);

    isRightExhausted = true;

    if (isLeftExhausted && isRightExhausted)
      stageEvents.TryInvoke(IStageService.StageEventType.AllExhausted);
  }

  public void OnRightRevived()
  {
    stageEvents.TryInvoke(IStageService.StageEventType.RightExhausted);

    isRightExhausted = false;
  }

  public void SubscribeOnEvent(IStageService.StageEventType type, UnityAction action)
  {
    stageEvents.AddEvent(type, action);    
  }

  public void UnsubscribeOnEvent(IStageService.StageEventType type, UnityAction action)
  {
    stageEvents.RemoveEvent(type, action);
  }

  public async UniTask<IPlayerPresenter> GetPresenterAsync(PlayerType type)
  {
    await playerSetupService.AwaitUntilSetupCompleteAsync();
    return playerSetupService.GetPresenter(type);
  }

  public void SetState(IStageService.State state)
    => stageState = state;

  public IStageService.State GetState()
    => stageState;
  #endregion

  private void SetupCamera(StageDataContainer stageData)
  {
    model.cameraService.SetSize(stageData.CameraSize);
  }

  private void SetupPlayers(StageDataContainer stageData, bool isEnableImmediately = false)
  {
    IStageObjectSetupService<IPlayerPresenter> stageObjectSetupService = playerSetupService;
    var leftPosition = stageData.LeftPlayerBeginTransform.position;
    var rightPosition = stageData.RightPlayerBeginTransform.position;
    stageObjectSetupService.SetupAsync(new PlayerService.SetupData(leftPosition,rightPosition),isEnableImmediately).Forget();
  }

  private void SetupTriggers(StageDataContainer stageData, bool isEnableImmediately = false)
  {
    IStageService stageService = this;
    IStageObjectSetupService<ITriggerTilePresenter> triggersSetupService = triggerTileSetupService;
    triggersSetupService.SetupAsync(new TriggerTileService.Model(stageData.TriggerTiles, stageService),isEnableImmediately).Forget();
  }

  private void SetupDynamicObstacles(StageDataContainer stageData)
  {
    foreach (var dynamicObstalce in stageData.DynamicObstacles)
    {

    }
  }
}
