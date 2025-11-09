using Cysharp.Threading.Tasks;
using UnityEngine;

public enum UIVisibleState
{
  None,

  Showing,
  Showed,

  Hiding,
  Hided,
}

public interface IUIPresenter
{
  public UniTask InitializeAsync(object model, IUIView view);

  public UIVisibleState GetVisibleState();

  public UniTask ShowAsync(bool isImmediately = false);

  public UniTask HideAsync(bool isImmediately = false);
}
