using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BasePlayerView : MonoBehaviour, IPlayerView
{
  [SerializeField] private Rigidbody rigidBody;

  private readonly List<Vector3> inputForces = new();

  private void FixedUpdate()
  {
    var velocity = inputForces.Count > 0 ? inputForces.Aggregate((force1, force2) => force1 + force2)
                                      : Vector3.zero;
      rigidBody.linearVelocity = velocity;
  }

  public void AddForce(Vector3 force)
    => inputForces.Add(force);

  public void RemoveForce(Vector3 force)
    => inputForces.Remove(force);

  public void SetActive(bool isActive)
    =>gameObject.SetActive(isActive);

  public void SetEuler(Vector3 euler)
    => transform.eulerAngles = euler;

  public void SetLocalPosition(Vector3 position)
    =>transform.localPosition = position;

  public void SetRoot(Transform root)
    => transform.SetParent(root);

  public void SetRotation(Quaternion rotation)
    => transform.rotation = rotation;

  public void SetScale(Vector3 scale)
    => transform.localScale = scale;

  public void SetWorldPosition(Vector3 worldPosition)
    => transform.position = worldPosition;
}
