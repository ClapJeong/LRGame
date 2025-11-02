using UnityEngine;

[CreateAssetMenu(fileName ="AdressableKeySO",menuName ="SO/AdressableKey")]
public class AddressableKeySO: ScriptableObject
{
  [SerializeField] private string leftPlayer;
  public string LeftPlayer => leftPlayer;

  [SerializeField] private string rightPlayer;
  public string RightPlayer => rightPlayer;

  [Space(20)]
  [Header("[ Scene ]")]
  [SerializeField] private string gameScene;
  public string GameScene => gameScene;
}
