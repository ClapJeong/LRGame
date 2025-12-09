using UnityEngine;

[CreateAssetMenu(fileName = "PlayerModelSO", menuName ="SO/PlayerModel")]
public class PlayerModelSO : ScriptableObject
{
  [SerializeField] private PlayerMovementData movement;
  public PlayerMovementData Movement => movement;

  [SerializeField] private PlayerHPData hp;
  public PlayerHPData HP => hp;
}
