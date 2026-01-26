using Cysharp.Threading.Tasks;
using System;
using UniRx;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public partial class GlobalManager : MonoBehaviour
{
  public static GlobalManager instance;

  [field: SerializeField] public TableContainer Table { get; private set; }
  [field: SerializeField] public UIManager UIManager { get; private set; }
  public FactoryManager FactoryManager { get; private set; }  
  public ResourceManager ResourceManager { get; private set; } 
  public SceneProvider SceneProvider { get; private set; }  
  public UIInputManager UIInputManager { get; private set; }
  public GameDataService GameDataService { get; private set; }
  public VeryFirstService VeryFirstService { get; private set; }
  public LocaleService LocaleService { get; private set; }

  [field: Space(10)]
  [field: SerializeField] public bool PlayVeryFirstCutscene = false;

  private CompositeDisposable disposables = new();

  private void Awake()
  {
    if (instance == null)
    {
      instance = this;
      DontDestroyOnLoad(gameObject);
      InitializeAsync().Forget();
    }
    else
      Destroy(gameObject);
  }

  private void OnDestroy()
  {
    disposables.Dispose();
  }

  private async UniTask InitializeAsync()
  {
    LocaleService = new(Table.LocalizationSO.LocalizeFonts);
    disposables.Add(LocaleService);

    FactoryManager = new();
    FactoryManager.Initialize();

    ResourceManager = new();
    disposables.Add(ResourceManager);

    UIInputManager = new(Table, FactoryManager.InputActionFactory);
    disposables.Add(UIInputManager);

    GameDataService = new(ResourceManager);
    await GameDataService.LoadDataAsync();

    UIManager.Initialize(ResourceManager, FactoryManager);

    VeryFirstService = new(Table.AddressableKeySO, ResourceManager, UIManager);

    SceneProvider = new(ResourceManager, UIManager, Table.AddressableKeySO);
    await SceneProvider.LoadSceneAsync(SceneType.Preloading, false);
  }

  public void Test_ChangeLocale(Locale locale)
  {
    LocalizationSettings.SelectedLocale = locale;
  }
}
