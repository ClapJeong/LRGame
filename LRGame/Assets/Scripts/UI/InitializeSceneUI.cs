using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class InitializeSceneUI : MonoBehaviour
{
  [SerializeField] private Button startButton;

  private readonly CompositeDisposable disposables = new();

  private void Awake()
  {
    startButton
      .OnClickAsObservable()
      .Take(1)
      .Subscribe(_ => ChangeToGameScene());
  }

  private void ChangeToGameScene()
  {
    ISceneProvider sceneProvider = GlobalManager.instance.SceneProvider;
    var token = destroyCancellationToken;
    sceneProvider.LoadSceneAsync(
      SceneType.Game,
      token,
      onProgress: null,
      onComplete: null,
      waitUntilLoad: null).Forget();
  }
}
