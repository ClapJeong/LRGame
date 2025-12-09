using Cysharp.Threading.Tasks;
using UnityEngine;

namespace LR.UI
{
  public interface ICanvasGroupView
  {
    public void SetAlpha(float alpha);

    public void EnableInteractive(bool enable);

    public void EnableRaycast(bool enable);
  }
}