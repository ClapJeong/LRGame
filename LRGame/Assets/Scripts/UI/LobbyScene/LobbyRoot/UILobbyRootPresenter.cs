using Cysharp.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UILobbyRootPresenter : IUIPresenter
  {
    public class Model
    {
      public string beginButtonSceneKey;

      public Model(string beginButtonSceneKey)
      {
        this.beginButtonSceneKey = beginButtonSceneKey;
      }
    }

    private readonly Model model;
    private readonly UILobbyViewContainer viewContainer;
    private readonly List<(ISubmitView, ILocalizeStringView)> stageButtons = new();

    public UILobbyRootPresenter(Model model, UILobbyViewContainer viewContainer)
    {
      this.model = model;
      this.viewContainer = viewContainer;

      CreateStageButtons().Forget();
    }

    public UIVisibleState GetVisibleState()
      => UIVisibleState.Showed;

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new System.NotImplementedException();
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    private async UniTask CreateStageButtons()
    {
      var table = GlobalManager.instance.Table.AddressableKeySO;
      var stageLabel = table.Label.Stage;
      var stageButtonKey = table.Path.Ui + table.UIName.LobbyStageButton;

      IResourceManager resourceManager = GlobalManager.instance.ResourceManager;
      var stages = await resourceManager.LoadAssetsAsync(stageLabel);

      for (int i = 0; i < stages.Count; i++)
      {
        var stageButtonObject = await resourceManager.CreateAssetAsync<GameObject>(stageButtonKey, viewContainer.stageButtonRoot);
        var submitView = stageButtonObject.GetComponent<BaseSubmitView>();
        var localizeStringView = stageButtonObject.GetComponent<BaseLocalizeStringView>();
        stageButtons.Add((submitView, localizeStringView));

        var index = i - 1;
        submitView.SubscribeOnSubmit(() =>
        {
          OnStageButtonClick(index);
          submitView.Enable(false);
        });
        localizeStringView.SetArgument(new() { index });
      }
    }

    private void OnStageButtonClick(int index)
    {
      GlobalManager.instance.selectedStage = index;
      var sceneProvider = GlobalManager.instance.SceneProvider;
      sceneProvider.LoadSceneAsync(
        SceneType.Game,
        CancellationToken.None,
        onProgress: null,
        onComplete: null).Forget();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target
      .OnDestroyAsObservable()
      .Subscribe(_ => Dispose());

    public void Dispose()
    {
      IUIPresenterContainer presenterContainer = GlobalManager.instance.UIManager;
      presenterContainer.Remove(this);
      if (viewContainer)
        GameObject.Destroy(viewContainer.gameObject);
    }
  }
}