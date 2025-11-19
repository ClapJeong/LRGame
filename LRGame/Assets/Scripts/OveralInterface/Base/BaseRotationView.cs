using UnityEngine;

public class BaseRotationView : MonoBehaviour, IRotationView
{
  public void AddEuler(Vector3 value)
    => transform.eulerAngles += value;

  public void AddRotation(Quaternion value)
    => transform.rotation *= value;

  public void SetEuler(Vector3 euler)
    => transform.eulerAngles = euler;

  public void SetRotaion(Quaternion quaternion)
    => transform.rotation = quaternion;
}