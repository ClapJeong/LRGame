using UnityEngine;

[CreateAssetMenu(fileName = "PlayerModelSO", menuName ="SO/PlayerModel")]
public class PlayerModelSO : ScriptableObject
{
  [field: SerializeField] public PlayerMovementData Movement {  get; set; }

  [field: Space(10)]
  [field: SerializeField] public PlayerEnergyData Energy { get; set; }
}
