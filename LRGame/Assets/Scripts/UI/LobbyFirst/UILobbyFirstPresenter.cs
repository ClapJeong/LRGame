using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

public class UILobbyFirstPresenter : IUIPresenter
{
  public class Model
  {
    public readonly string beginButtonText;
    public readonly string beginButtonSceneKey;

    public Model(string beginButtonText, string beginButtonSceneKey)
    {
      this.beginButtonText = beginButtonText;
      this.beginButtonSceneKey = beginButtonSceneKey;
    }
  }

  private readonly Model model;
  private readonly UILobbyViewContainer viewContainer;
  private readonly IButtonController beginButton;
  private readonly ITMPController beginButtonText;

  public UILobbyFirstPresenter(Model model, UILobbyViewContainer viewContainer)
  {
    this.model = model;
    this.viewContainer = viewContainer;
    this.beginButton = viewContainer.beginButton;
    this.beginButtonText = viewContainer.beginButton;

    beginButtonText.SetText(model.beginButtonText);
    beginButton.SubscribeOnClick(OnBeginButtonClick);
  }

  public UIVisibleState GetVisibleState()
    => UIVisibleState.Showed;

  public UniTask HideAsync(bool isImmediately = false)
  {
    throw new System.NotImplementedException();
  }

  public void SetVisibleState(UIVisibleState visibleState)
  {
    throw new System.NotImplementedException();
  }

  public UniTask ShowAsync(bool isImmediately = false)
  {
    throw new System.NotImplementedException();
  }

  private void OnBeginButtonClick()
  {
    var compositeDisposable = new CompositeDisposable();
    compositeDisposable.Add(beginButton);

    beginButton.SetInteractable(false);
    beginButton.UnsubscribeOnClick(OnBeginButtonClick);

    var sceneProvider = GlobalManager.instance.SceneProvider;
    sceneProvider.LoadSceneAsync(
      SceneType.Game,
      CancellationToken.None,
      onProgress: null,
      onComplete: compositeDisposable.Dispose).Forget();
  }

  public IDisposable AttachOnDestroy(GameObject target)
    => target
    .OnDestroyAsObservable()
    .Subscribe(_ => Dispose());

  public void Dispose()
  {
    IUIPresenterContainer presenterContainer = GlobalManager.instance.UIManager;
    presenterContainer.Remove(this);
    GameObject.Destroy(viewContainer.gameObject);
  }
}
