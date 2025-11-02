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
    GameManager.instance.SceneProvider.LoadSceneAsync(
      SceneType.Game,
      UnityEngine.SceneManagement.LoadSceneMode.Single,
      onProgress: null,
      waitUntilLoad: null).Forget();
  }
}
