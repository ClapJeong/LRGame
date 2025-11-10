using Cysharp.Threading.Tasks;
using UnityEngine;

public interface IFirstUICreator
{
  public UniTask<GameObject> CreateFirstUIViewAsync(SceneType sceneType);
}
