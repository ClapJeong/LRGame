using Cysharp.Threading.Tasks;
using LR.UI.Preloading;
using System;
using UnityEngine;
using UnityEngine.Events;

public class VeryFirstService
{
  private readonly AddressableKeySO addressableKeySO;
  private readonly IResourceManager resourceManager;
  private readonly ICanvasProvider canvasProvider;

  private UIVeryFirstCutscene firstCutscene;

  public VeryFirstService(AddressableKeySO addressableKeySO, IResourceManager resourceManager, ICanvasProvider canvasProvider)
  {
    this.addressableKeySO = addressableKeySO;
    this.resourceManager = resourceManager;
    this.canvasProvider = canvasProvider;
  }

  public async UniTask CreateFirstTimelineAsync()
  {
    var key = addressableKeySO.Path.UI + addressableKeySO.UIName.VeryFirstCutscene;
    firstCutscene = await resourceManager.CreateAssetAsync<UIVeryFirstCutscene>(key, canvasProvider.GetCanvas(UIRootType.SceneLoading).transform);
  }

  public void PlayFirstTimeline(UnityAction onComplete)
  {
    firstCutscene.PlayCutscene(onComplete);    
  }

  public void DestroyCutscene()
  {
    GameObject.Destroy(firstCutscene.gameObject);
    firstCutscene = null;
  }
}
