using UnityEngine;
using LR.UI.Enum;

public interface ICanvasProvider
{
  public Canvas GetCanvas(RootType rootType);
}
