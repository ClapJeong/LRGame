using LR.UI;
using System;
using System.Collections.Generic;

public class UIPresenterFactory : IUIPresenterFactory
{
  private readonly IUIPresenterContainer container;
  private readonly Dictionary<Type, Func<IUIPresenter>> presenterRegisters = new();

  public UIPresenterFactory(IUIPresenterContainer container)
  {
    this.container = container;
  }

  public void Register<T>(Func<T> constructor) where T : IUIPresenter
  {
    var type = typeof(T);
    presenterRegisters[type] = () => constructor();
  }

  public T Create<T>() where T : IUIPresenter
  {
    var type = typeof(T);
    if (presenterRegisters.ContainsKey(type) == false)
      throw new System.NotImplementedException($"{type.Name} does not exist");

    var presenter = (T)presenterRegisters[type]();
    container.Add(presenter);

    return presenter;
  }
}