using Cysharp.Threading.Tasks;
using LR.UI;
using LR.UI.Indicator;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestButtonPanel: MonoBehaviour
{
  [SerializeField] private TestButton testButtonPrefab;
  [SerializeField] private Transform buttonRoot;
  [SerializeField] private Transform indicatorRoot;

  private Stack<Transform> panelRoot = new();

  private void Awake()
  {
    IUISelectionEventService selectionEventService = GlobalManager.instance.UIManager;
    selectionEventService.SubscribeEvent(IUISelectionEventService.EventType.OnEnter, OnSelectEnter);
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.PageUp))
    {
      CreateButtons(out var firstButton);
      CreateIndicatorAsync(firstButton.GetComponent<IRectView>()).Forget();
      IUIDepthService depthService = GlobalManager.instance.UIManager;
      depthService.RaiseDepth(firstButton.gameObject);
    }

    if (Input.GetKeyDown(KeyCode.PageDown))
    {
      Destroy(panelRoot.Pop().gameObject);
    }
  }

  private async UniTask CreateIndicatorAsync(IRectView firstRect)
  {
    IUIIndicatorService indicatorService = GlobalManager.instance.UIManager;
    var indicator = await indicatorService.CreateAsync(panelRoot.Peek(), firstRect);
    indicatorService.Push(indicator);
    indicatorService.AttachCurrentWithGameObject(gameObject);    
  }

  private void OnSelectEnter(IRectView rectView)
  {
    IUIIndicatorService indicatorService = GlobalManager.instance.UIManager;
    if(indicatorService.TryGetCurrent(out var indicator))
      indicator.MoveAsync(rectView).Forget();
  }

  private void CreateButtons(out GameObject firstButton)
  {
    var root = new GameObject($"root {panelRoot.Count}", typeof(RectTransform), typeof(Image));
    panelRoot.Push(root.transform);
    root.transform.SetParent(buttonRoot);
    root.GetComponent<RectTransform>().anchoredPosition = new Vector2(Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f));
    root.GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.5f);
    var horizontalSpace = 160.0f;
    var verticalSpace = 160.0f;

    var row = Random.Range(2, 5);
    var column = Random.Range(2, 5);
    firstButton = null;
    var navigations = new BaseNavigationView[row, column];
    for (int i = 0; i < row; i++)
    {
      for (int j = 0; j < column; j++)
      {
        var button = Instantiate(testButtonPrefab, root.transform);
        var rect = button.GetComponent<IRectView>();
        var width = Random.Range(50.0f, 150.0f);
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
        Set(Direction.Up, x: j, y: i + 1);
        Set(Direction.Right, x: j + 1, y: i);
        Set(Direction.Down, x: j, y: i - 1);
        Set(Direction.Left, x: j - 1, y: i);

        void Set(Direction direction, int x, int y)
        {
          if (x < 0 || x == column || y < 0 || y == row)
            return;

          navigations[i, j].AddNavigation(direction, navigations[y, x].GetSelectable());
        }
      }
    }
  }

  private void OnDestroy()
  {
    IUISelectionEventService selectionEventService = GlobalManager.instance.UIManager;
    selectionEventService.UnsubscribeEvent(IUISelectionEventService.EventType.OnEnter, OnSelectEnter);
  }
}