using UnityEngine;

public class BaseSpriteRendererView : MonoBehaviour, ISpriteRendererView
{
  private SpriteRenderer spriteRenderer;

  private void OnEnable()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }

  public void SetAlpha(float alpha)
  {
    var color = spriteRenderer.color;
    if (color.a != alpha)
    {
      color.a = alpha;
      spriteRenderer.color = color;
    }
  }

  public void SetColor(Color color)
  {
    if(spriteRenderer.color != color)
      spriteRenderer.color = color;
  }

  public void SetSprite(Sprite sprite)
    =>spriteRenderer.sprite = sprite;
}