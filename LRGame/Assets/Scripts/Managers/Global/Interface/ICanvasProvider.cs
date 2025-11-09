using UnityEngine;

public interface ICanvasProvider
{
  public Canvas GetCanvas(UIRootType rootType);
}
