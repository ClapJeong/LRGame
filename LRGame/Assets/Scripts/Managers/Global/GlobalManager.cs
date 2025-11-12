using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using System.IO;
using System.Threading;

public class GlobalManager : MonoBehaviour, IGameDataController
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

  private string GameDataPath;
  private GameData gameData;
  public int selectedStage = 0;

  private void Awake()
  {
    GameDataPath = Application.persistentDataPath + "/GameData.json";
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

  public async UniTask SaveAsync(CancellationToken token)
  {
    if(gameData==null)
      gameData = new GameData();

    var json = JsonUtility.ToJson(gameData);
    await  File.WriteAllTextAsync(GameDataPath, json,token);
  }

  public async UniTask LoadAsync(CancellationToken token)
  {
    if (File.Exists(GameDataPath) == false)
    {
      gameData = new GameData();
    }
    else
    {
      var text = await File.ReadAllTextAsync(GameDataPath, token);
      gameData = JsonUtility.FromJson<GameData>(text);
    }    
  }

  public int GetClearStage()
  {
    return gameData.clearedStage;
  }

  public void SetClearStage(int stage)
  {
    gameData.clearedStage = stage;
  }
}
