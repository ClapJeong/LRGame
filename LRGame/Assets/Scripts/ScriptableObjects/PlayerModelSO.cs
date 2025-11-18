using UnityEngine;

[CreateAssetMenu(fileName = "PlayerModelSO", menuName ="SO/PlayerModel")]
public class PlayerModelSO : ScriptableObject
{
  [System.Serializable]
  public class MovementData
  {
    [SerializeField] private KeyCode upKeyCode;
    public KeyCode UpKeyCode => upKeyCode;

    [SerializeField] private KeyCode downKeyCode;
    public KeyCode DownKeyCode => downKeyCode;

    [SerializeField] private KeyCode leftKeyCode;
    public KeyCode LeftKeyCode => leftKeyCode;

    [SerializeField] private KeyCode rightKeyCode;
    public KeyCode RightKeyCode => rightKeyCode;

    [Space(10)]
    [SerializeField] private Vector3 upVector;
    public Vector3 UpVector => upVector;

    [SerializeField] private Vector3 downVector;
    public Vector3 DownVector => downVector;

    [SerializeField] private Vector3 leftVector;
    public Vector3 LeftVector => leftVector;

    [SerializeField] private Vector3 rightVector;
    public Vector3 RightVector => rightVector;

    [SerializeField] private float acceleration;
    public float Acceleration => acceleration;

    [SerializeField] private float decceleration;
    public float Decceleration => decceleration;

    [SerializeField] private float maxSpeed;
    public float MaxSpeed => maxSpeed;
  }
  [SerializeField] private MovementData movement;
  public MovementData Movement => movement;
}
