using System;
using UnityEngine;

public interface IUIPresenterFactory
{
  public void Register<T>(Func<T> constructor) where T : IUIPresenter;

  public T Create<T>() where T : IUIPresenter;
}
