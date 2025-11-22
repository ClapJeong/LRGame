using UnityEngine;

public interface IRotationView
{
    public void SetRotaion(Quaternion quaternion);

  public void AddRotation(Quaternion value);

  public void SetEuler(Vector3 euler);

  public void AddEuler(Vector3 value);
}
