using UnityEngine;

public interface ICanvasGroupController
{
  public void CacheCanvasGroup();

  public void SetAlpha(float alpha);

  public void EnableInteractive(bool enable);

  public void EnableRaycast(bool enable);   
}
