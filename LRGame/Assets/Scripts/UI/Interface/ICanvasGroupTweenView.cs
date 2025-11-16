using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI
{
  public interface ICanvasGroupTweenView
  {
    public UniTask DoFade(float alpha, float duration,CancellationToken token = default);
  }
}