using UnityEngine;

public interface IPlayerView : ITransformController
{
    public void AddForce(Vector3 force);

  public void RemoveForce(Vector3 force);
}
