using UniRx;
using UnityEngine;
using UnityEngine.AddressableAssets;

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
    }
      else
      Destroy(gameObject);    
  }

  private void OnDestroy()
  {
    disposables.Dispose();
  }
}
