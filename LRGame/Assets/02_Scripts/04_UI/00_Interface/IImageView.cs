using UnityEngine;

namespace LR.UI
{
  public interface IImageView
  {
    public void SetEnable(bool enable);

    public void SetColor(Color color);

    public void SetAlpha(float alpha);

    public void SetSprite(Sprite sprite);

    public void SetFillAmount(float value);
  }
}