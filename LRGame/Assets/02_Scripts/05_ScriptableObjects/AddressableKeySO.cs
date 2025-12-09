using UnityEngine;

[CreateAssetMenu(fileName ="AdressableKeySO",menuName ="SO/AdressableKey")]
public class AddressableKeySO: ScriptableObject
{
  [Header("[ Labels ]")]
  [SerializeField] private AddressableLabel label;
  public AddressableLabel Label => label;

  [Header("[ Paths ]")]
  [SerializeField] private AddresasblePath path;
  public AddresasblePath Path=>path;

  [Header("Names")]
  [SerializeField] private SceneName sceneName;
  public SceneName SceneName => sceneName;

  [Space(5)]
  [SerializeField] private PlayerName playerName;
  public PlayerName PlayerName => playerName;

  [Space(5)]
  [SerializeField] private UIName uiName;
  public UIName UIName => uiName;

  [Space(5)]
  [SerializeField] private StageName stageName;
  public StageName StageName => stageName;
}
