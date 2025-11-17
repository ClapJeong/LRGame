using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;

namespace LR.UI
{
  public interface IUIPresenter : IUIVisibleStateContainer, IDisposable
  {
    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default);

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default);

    public IDisposable AttachOnDestroy(GameObject target);
  }
}