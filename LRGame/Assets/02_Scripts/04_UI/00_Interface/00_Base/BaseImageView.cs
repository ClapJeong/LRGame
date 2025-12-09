using UnityEngine;
using UnityEngine.UI;

namespace LR.UI
{
  [RequireComponent(typeof(Image))]
  public class BaseImageView : MonoBehaviour, IImageView
  {
    private Image image;
    private Image Image
    {
      get
      {
        if (image == null)
          image = GetComponent<Image>();
        return image;
      }
    }

    public void SetAlpha(float alpha)
    {
      var color = Image.color;
      color.a = alpha;
      Image.color = color;
    }

    public void SetColor(Color color)
      => Image.color = color;

    public void SetEnable(bool enable)
      => Image.enabled = enable;

    public void SetFillAmount(float value)
      => Image.fillAmount = value;

    public void SetSprite(Sprite sprite)
      => Image.sprite = sprite;
  }
}