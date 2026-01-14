using UnityEngine;

[CreateAssetMenu(fileName = "PlayerModelSO", menuName ="SO/PlayerModel")]
public class PlayerModelSO : ScriptableObject
{
  [field: SerializeField] public PlayerMovementData Movement {  get; private set; }

  [field: Space(10)]
  [field: SerializeField] public PlayerEnergyData Energy { get; private set; }
  [field: Space(10)]
  [field: SerializeField] public PlayerStunData Stun { get; private set; }
}
