using UnityEngine;

[System.Serializable]
public class AddressableLabel
{
  [SerializeField] private string preload;
  public string PreLoad => preload;

  [SerializeField] private string stage;
  public string Stage => stage;
}
