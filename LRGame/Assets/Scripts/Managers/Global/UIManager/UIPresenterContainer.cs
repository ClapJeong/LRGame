using LR.UI;
using System.Collections.Generic;
using System;
using System.Linq;

public class UIPresenterContainer : IUIPresenterContainer
{
  private readonly Dictionary<Type, List<IUIPresenter>> cachedPresenters = new();

  public void Add(IUIPresenter presenter)
  {
    var type = presenter.GetType();

    if (cachedPresenters.TryGetValue(type, out var existList))
      existList.Add(presenter);
    else
      cachedPresenters[type] = new List<IUIPresenter> { presenter };
  }

  public void Remove(IUIPresenter presenter)
  {
    var type = presenter.GetType();

    if (cachedPresenters.TryGetValue(type, out var existList))
      existList.Remove(presenter);
  }

  public IReadOnlyList<T> GetAll<T>() where T : IUIPresenter
  {
    if (cachedPresenters.TryGetValue(typeof(T), out var existList))
      return existList.Cast<T>().ToList();
    else
      return Array.Empty<T>();
  }

  public T GetFirst<T>() where T : IUIPresenter
    => GetAll<T>().FirstOrDefault();

  public T GetLast<T>() where T : IUIPresenter
    => GetAll<T>().LastOrDefault();
}