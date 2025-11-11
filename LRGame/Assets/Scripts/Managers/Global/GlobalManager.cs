using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class GlobalManager : MonoBehaviour
{
  public static GlobalManager instance;

  private FactoryManager factoryManager;
  public FactoryManager FactoryManager => factoryManager;

  [SerializeField] private TableContainer table;
  public TableContainer Table => table;

  private ResourceManager resourceManager;
  public ResourceManager ResourceManager => resourceManager;

  private CompositeDisposable disposables = new();

  [SerializeField] private SceneProvider sceneProvider;
  public SceneProvider SceneProvider => sceneProvider;

  [SerializeField] private UIManager uiManager;
  public UIManager UIManager => uiManager;

  private void Awake()
  {
    if (instance == null)
    {
      instance = this;
      DontDestroyOnLoad(gameObject);

      factoryManager = new FactoryManager();
      factoryManager.Initialize();

      resourceManager = new ResourceManager();
      disposables.Add(resourceManager);

      SceneProvider.LoadSceneAsync(SceneType.Preloading, System.Threading.CancellationToken.None).Forget();
    }
      else
      Destroy(gameObject);    
  }

  private void OnDestroy()
  {
    disposables.Dispose();
  }

  public void Test_ChangeLocale(Locale locale)
  {
    LocalizationSettings.SelectedLocale = locale;
  }
}
