using UnityEngine;

[CreateAssetMenu(fileName ="AdressableKeySO",menuName ="SO/AdressableKey")]
public class AddressableKeySO: ScriptableObject
{
  [Header("[ Labels ]")]
  [field: SerializeField] public AddressableLabel Label {  get; set; }

  [Header("[ Paths ]")]
  [field: SerializeField] public AddresasblePath Path {  get; set; }

  [field: Space(10)]
  [Header("Names")]
  [field: SerializeField] public SceneName SceneName {  get; set; }

  [field: SerializeField] public PlayerName PlayerName {  get; set; }

  [field: SerializeField] public UIName UIName {  get; set; }

  [field: SerializeField] public StageName StageName {  get; set; }
}
