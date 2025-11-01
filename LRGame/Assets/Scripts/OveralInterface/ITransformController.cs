using UnityEngine;

public interface ITransformController
{
  public void SetRoot(Transform root);

  public void SetActive(bool isActive);

  public void SetLocalPosition(Vector3 position);

  public void SetWorldPosition(Vector3 worldPosition);

  public void SetEuler(Vector3 euler);

  public void SetRotation(Quaternion rotation);

  public void SetScale(Vector3 scale);
}
