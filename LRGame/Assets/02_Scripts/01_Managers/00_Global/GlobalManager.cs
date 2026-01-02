using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class GlobalManager : MonoBehaviour
{
  public static GlobalManager instance;

  [field: SerializeField] public TableContainer Table { get; private set; }
  [field: SerializeField] public UIManager UIManager { get; private set; }
  public FactoryManager FactoryManager { get; private set; }  
  public ResourceManager ResourceManager { get; private set; } 
  public SceneProvider SceneProvider { get; private set; }  
  public UIInputManager UIInputManager { get; private set; }
  public GameDataService GameDataService { get; private set; }
  public EffectService EffectService { get; private set; }

  private CompositeDisposable disposables = new();
  private void Awake()
  {
    if (instance == null)
    {
      instance = this;
      DontDestroyOnLoad(gameObject);

      FactoryManager = new ();
      FactoryManager.Initialize();

      ResourceManager = new ();
      disposables.Add(ResourceManager);

      UIInputManager = new (Table, FactoryManager.InputActionFactory);
      disposables.Add(UIInputManager);

      GameDataService = new (ResourceManager);
      GameDataService.LoadDataAsync().Forget();

      UIManager.Initialize(ResourceManager, FactoryManager);

      EffectService = new(ResourceManager, Table.AddressableKeySO);

      SceneProvider = new (ResourceManager, UIManager, Table.AddressableKeySO);
      SceneProvider.LoadSceneAsync(SceneType.Preloading, false).Forget();
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
    => GameDataService.Debugging_RaiseClearData();

  public void Debugging_MinusClearState()
    => GameDataService.Debugging_LowerClearData();

  public void Debugging_ClearClearStage()
    => GameDataService.Debugging_RaiseClearData();

  public void Debugging_ClearAllConditions()
    => GameDataService.Debugging_ClearAllDialogueConditions();
  #endregion
}
