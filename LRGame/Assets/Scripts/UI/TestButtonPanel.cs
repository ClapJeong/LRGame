using UnityEngine;

public class TestButtonPanel: MonoBehaviour
{
  [SerializeField] private TestButton testButtonPrefab;

  private void Awake()
  {
    var buttonRect = testButtonPrefab.GetComponent<RectTransform>();

    var width = buttonRect.rect.width;
    var height = buttonRect.rect.height;

    var horizontalSpace = 15.0f;
    var verticalSpace = 30.0f;

    var row = Random.Range(2, 5);
    var column = Random.Range(2, 5);

    for(int i=0; i<row; i++)
    {
      for(int j=0; j<column; j++)
      {
        var button = Instantiate(testButtonPrefab);
        var rect = button.GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(i*(width + horizontalSpace), j*(height + verticalSpace));
      }
    }
  }
}