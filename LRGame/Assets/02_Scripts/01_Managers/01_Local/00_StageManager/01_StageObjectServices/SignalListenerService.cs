using Cysharp.Threading.Tasks;
using LR.Stage.SignalListener;
using LR.Stage.StageDataContainer;
using System.Collections.Generic;

public class SignalListenerService :
    IStageObjectSetupService<SignalListener>,
    IStageObjectControlService<SignalListener>
  {
  private readonly IEffectService effectService;
  private readonly ISignalSubscriber signalSubscriber;
  private readonly ISignalIDLifeProvider signalIDLifeProvider;
  private readonly TableContainer table;
  private readonly IResourceManager resourceManager;

  private List<BaseSignalPreview> previews = new();
  private List<SignalListener> signalListeners;
  private bool isSetup = false;

  public SignalListenerService(IEffectService effectService, ISignalSubscriber signalSubscriber, ISignalIDLifeProvider signalIDLifeProvider, TableContainer table, IResourceManager resourceManager)
  {
    this.effectService = effectService;
    this.signalSubscriber = signalSubscriber;
    this.signalIDLifeProvider = signalIDLifeProvider;
    this.table = table;
    this.resourceManager = resourceManager;
  }

  public async UniTask<List<SignalListener>> SetupAsync(StageDataContainer stageDataContainer, bool isEnableImmediately = false)
  {
    signalListeners = stageDataContainer.SignalListeners;

    foreach (var signalListener in signalListeners)
    {
      signalListener.Initialize(effectService);

      var signalKey = signalListener.RequireKey;
      signalSubscriber.SubscribeSignalActivate(signalKey, signalListener.OnActivate);
      signalSubscriber.SubscribeSignalDeactivate(signalKey, signalListener.OnDeactivate);

      var signalIDLifes = signalIDLifeProvider.GetSignalIDLifes(signalKey);
      var previewPositions = signalListener.GetPreviewPositions(signalIDLifes.Count);
      var count = 0;
      foreach (var pair in signalIDLifes)
      {
        var id = pair.Key;
        var life = pair.Value;
        var signalPreviewKey = table.AddressableKeySO.Path.GameObjects + life switch
        {
          LR.Stage.TriggerTile.Enum.SignalLife.OnlyActivate => table.AddressableKeySO.GameObjectName.ACSignalPreview,
          LR.Stage.TriggerTile.Enum.SignalLife.ActivateAndDeactivate => table.AddressableKeySO.GameObjectName.ACDCSignalPreview,
          _ => throw new System.NotImplementedException(),
        };
        var signalPreview = await resourceManager.CreateAssetAsync<BaseSignalPreview>(signalPreviewKey, signalListener.transform);
        signalPreview.Initialize(previewPositions[count], signalListener.previewColor);
        previews.Add(signalPreview);

        signalSubscriber.SubscribeIDActivate(signalKey, id, onActivate);
        signalSubscriber.SubscribeIDDeactivate(signalKey, id, onDeactivate);

        void onActivate(int activatedID)
        {
          if (activatedID != id)
            return;
          signalPreview.Activate();
        }
        void onDeactivate(int deactivatedID)
        {
          if (deactivatedID != id)
            return;
          signalPreview.Deactivate();
        }

        count++;
      }
    }
    isSetup = true;

    return signalListeners;
  }

  public async UniTask AwaitUntilSetupCompleteAsync()
  {
    await UniTask.WaitUntil(()=>isSetup);
  }

  public void EnableAll(bool isEnable)
  {
    foreach (var signalLister in signalListeners)
      signalLister.Enable(isEnable);
  }

  public void Release()
  {
    
  }

  public void RestartAll()
  {
    foreach (var signalLister in signalListeners)
      signalLister.Restart();

    foreach (var signalPreview in previews)
      signalPreview.Restart();
  }
}

