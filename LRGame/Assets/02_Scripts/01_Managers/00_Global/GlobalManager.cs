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

  private SceneProvider sceneProvider;
  public SceneProvider SceneProvider => sceneProvider;

  [SerializeField] private UIManager uiManager;
  public UIManager UIManager => uiManager;

  [SerializeField] private UIInputManager uiInputManager;
  public UIInputManager UIInputManager => uiInputManager;

  private GameDataService gameDataService;
  public GameDataService GameDataService => gameDataService;

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

      uiInputManager = new UIInputManager(table: table, inputActionFactory: factoryManager.InputActionFactory);
      disposables.Add(uiInputManager);

      gameDataService = new GameDataService(resourceManager: resourceManager);
      gameDataService.LoadDataAsync().Forget();

      uiManager.Initialize();

      sceneProvider = new SceneProvider();
      SceneProvider.LoadSceneAsync(SceneType.Preloading).Forget();      
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

  #region Debugging
  public void Debugging_AddClearStage()
    => gameDataService.Debugging_RaiseClearData();

  public void Debugging_ClearClearStage()
    => gameDataService.Debugging_RaiseClearData();
  #endregion
}
