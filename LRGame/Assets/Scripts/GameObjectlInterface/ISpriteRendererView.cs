using UnityEngine;

public interface ISpriteRendererView
{
  public void SetSprite(Sprite sprite);

  public void SetColor(Color color);

  public void SetAlpha(float alpha);
}