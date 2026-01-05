using UnityEngine;

[System.Serializable]
public class PlayerMovementData
{
  [field: SerializeField] public CharacterMoveKeyCodeData KeyCodeData { get; private set; }
  
  [Space(10)]
  [SerializeField] private Vector3 upVector;
  public Vector3 UpVector => upVector;

  [SerializeField] private Vector3 downVector;
  public Vector3 DownVector => downVector;

  [SerializeField] private Vector3 leftVector;
  public Vector3 LeftVector => leftVector;

  [SerializeField] private Vector3 rightVector;
  public Vector3 RightVector => rightVector;

  [Space(10)]

  [SerializeField] private float acceleration;
  public float Acceleration => acceleration;

  [SerializeField] private float decceleration;
  public float Decceleration => decceleration;

  [SerializeField] private float maxSpeed;
  public float MaxSpeed => maxSpeed;
}
