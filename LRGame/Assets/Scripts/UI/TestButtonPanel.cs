using Cysharp.Threading.Tasks;
using LR.UI;
using LR.UI.Indicator;
using UnityEngine;

public class TestButtonPanel: MonoBehaviour
{
  [SerializeField] private TestButton testButtonPrefab;
  [SerializeField] private Transform buttonRoot;
  [SerializeField] private Transform indicatorRoot;
  private IUIIndicatorPresenter indicator;

  private void Awake()
  {
    var horizontalSpace = 15.0f;
    var verticalSpace = 30.0f;

    var row = Random.Range(2, 5);
    var column = Random.Range(2, 5);

    var navigations = new BaseNavigationView[row,column];
    GameObject firstButton = null;
    for(int i=0; i< row; i++)
    {
      for(int j=0; j< column; j++)
      {
        var button = Instantiate(testButtonPrefab, buttonRoot);
        var rect = button.GetComponent<IRectView>();
        var width = Random.Range(50.0f,150.0f);
        var height = Random.Range(50.0f, 150.0f);
        rect.SetRect(new Vector2(width, height));

        rect.SetAnchoredPosition(new Vector2(j * (width + horizontalSpace), i * (height + verticalSpace)));

        button.GetComponent<BaseSubmitView>().SubscribeOnSubmit(() => Debug.Log($"[{i},{j}]"));
        navigations[i, j] = button.GetComponent<BaseNavigationView>();

        if (firstButton == null)
          firstButton = button.gameObject;
      }
    }

    for (int i = 0; i < row; i++)
    {
      for (int j = 0; j < column; j++)
      {        
        Set(Direction.Up,     x: j,     y: i + 1);
        Set(Direction.Right,  x: j + 1, y: i);
        Set(Direction.Down,   x: j,     y: i - 1);
        Set(Direction.Left,   x: j - 1, y: i);

        void Set(Direction direction, int x, int y)
        {
          if (x < 0 || x == column || y < 0 || y == row)
            return;

          navigations[i, j].AddNavigation(direction, navigations[y, x].GetSelectable());
        }
      }
     }

    CreateIndicatorAsync(firstButton.GetComponent<IRectView>()).Forget();
    IUIDepthService depthService = GlobalManager.instance.UIManager;
    depthService.RaiseDepth(firstButton.gameObject);
  }

  private async UniTask CreateIndicatorAsync(IRectView firstRect)
  {
    IUIIndicatorService indicatorService = GlobalManager.instance.UIManager;
    indicator = await indicatorService.CreateAsync(indicatorRoot, firstRect);
    indicatorService.Push(indicator);
    indicatorService.AttachCurrentWithGameObject(gameObject);

    IUISelectionEventService selectionEventService = GlobalManager.instance.UIManager;
    selectionEventService.SubscribeEvent(IUISelectionEventService.EventType.OnEnter, OnSelectEnter);
  }

  private void OnSelectEnter(IRectView rectView)
  {
    indicator.MoveAsync(rectView).Forget();
  }

  private void OnDestroy()
  {
    IUISelectionEventService selectionEventService = GlobalManager.instance.UIManager;
    selectionEventService.UnsubscribeEvent(IUISelectionEventService.EventType.OnEnter, OnSelectEnter);
  }
}