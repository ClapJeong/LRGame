using UnityEngine;

[System.Serializable]
public class AddresasblePath
{
  [field: SerializeField] public string Player {  get; private set; }
  [field: SerializeField] public string UI {  get; private set; }
  [field: SerializeField] public string Scene {  get; private set; }
  [field: SerializeField] public string Stage {  get; private set; }
  [field: SerializeField] public string LeftPortrait {  get; private set; }
  [field: SerializeField] public string CenterPortrait { get; private set; }
  [field: SerializeField] public string RightPortrait { get; private set; }
}
