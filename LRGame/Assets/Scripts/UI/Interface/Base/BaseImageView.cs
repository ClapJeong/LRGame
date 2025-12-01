using UnityEngine;
using UnityEngine.UI;

namespace LR.UI
{
  [ExecuteInEditMode]
  [RequireComponent(typeof(Image))]
  public class BaseImageView : MonoBehaviour, IImageView
  {
    private Image image;

    private void OnEnable()
    {
      image = GetComponent<Image>();
    }

    public void SetAlpha(float alpha)
    {
      var color = image.color;
      color.a = alpha;
      image.color = color;
    }

    public void SetColor(Color color)
      => image.color = color;

    public void SetEnable(bool enable)
      => image.enabled = enable;

    public void SetFillAmount(float value)
      => image.fillAmount = value;

    public void SetSprite(Sprite sprite)
      => image.sprite = sprite;
  }
}