using Cysharp.Threading.Tasks;
using System;
using UnityEngine;


public interface IUIPresenter: IUIVisibleStateContainer, IDisposable
{
  public UniTask ShowAsync(bool isImmediately = false);

  public UniTask HideAsync(bool isImmediately = false);

  public IDisposable AttachOnDestroy(GameObject target);
}
