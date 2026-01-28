using Cysharp.Threading.Tasks;
using LR.UI.Preloading;
using LR.UI.Enum;
using UnityEngine.Events;

public class VeryFirstService
{
  private UIVeryFirstLocale firstLocale;
  private UIVeryFirstCutscene firstCutscene;

  public VeryFirstService()
  {

  }

  public async UniTask CreateFirstLocaleUI(
    AddressableKeySO addressableKeySO,
    IResourceManager resourceManager,
    ICanvasProvider canvasProvider)
  {
    var key = addressableKeySO.Path.UI + addressableKeySO.UIName.VeryFirstLocale;
    firstLocale = await resourceManager.CreateAssetAsync<UIVeryFirstLocale>(key, canvasProvider.GetCanvas(RootType.SceneLoading).transform);
  }

  public async UniTask InitializeFirstLocaleUIAsync(
    LocaleService localeService,
    IUIIndicatorService indicatorService,
    IUISelectedGameObjectService selectedGameObjectService,
    IUIDepthService depthService,
    IUIInputManager uiInputManager,
    UnityAction onConfirm)
  {
    var model = new UIVeryFirstLocale.Model(
      localeService,
      indicatorService,
      selectedGameObjectService,
      depthService,
      uiInputManager,
      onConfirm);
    await firstLocale.InitializeAsync(model);
  }

  public async UniTask DestroyFirstLocaleUIAsync(IResourceManager resourceManager)
    => await firstLocale.DestroyAsync(resourceManager);

  public async UniTask CreateFirstTimelineAsync(
    AddressableKeySO addressableKeySO,
    IResourceManager resourceManager,
    ICanvasProvider canvasProvider)
  {
    var key = addressableKeySO.Path.UI + addressableKeySO.UIName.VeryFirstCutscene;
    firstCutscene = await resourceManager.CreateAssetAsync<UIVeryFirstCutscene>(key, canvasProvider.GetCanvas(RootType.SceneLoading).transform);
  }

  public void PlayFirstTimeline(UnityAction onComplete)
  {
    firstCutscene.PlayCutscene(onComplete);    
  }

  public void DestroyCutscene(IResourceManager resourceManager)
  {
    firstCutscene.DestroyAsync(resourceManager).Forget();
    firstCutscene = null;
  }
}
