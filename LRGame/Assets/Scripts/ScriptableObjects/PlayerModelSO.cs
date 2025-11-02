using UnityEngine;

[CreateAssetMenu(fileName = "PlayerModelSO", menuName ="SO/PlayerModel")]
public class PlayerModelSO : ScriptableObject
{
  [SerializeField] private KeyCode upKeyCode;
  public KeyCode UpKeyCode => upKeyCode;

  [SerializeField] private KeyCode downKeyCode;
  public KeyCode DownKeyCode => downKeyCode;

  [SerializeField] private KeyCode leftKeyCode;
  public KeyCode LeftKeyCode => leftKeyCode;

  [SerializeField] private KeyCode rightKeyCode;
  public KeyCode RightKeyCode => rightKeyCode;
}
