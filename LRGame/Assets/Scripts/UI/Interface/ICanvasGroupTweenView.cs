using Cysharp.Threading.Tasks;
using System.Threading;
using UnityEngine;

namespace LR.UI
{
  public interface ICanvasGroupTweenView
  {
    public UniTask DoFadeAsync(float alpha, float duration,CancellationToken token = default);
  }
}