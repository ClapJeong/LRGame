using UnityEngine;

[System.Serializable]
public class AddresasblePath
{
  [SerializeField] private string player;
  public string Player => player;

  [Space(5)]
  [SerializeField] private string ui;
  public string Ui => ui;

  [Space(5)]
  [SerializeField] private string scene;
  public string Scene => scene;

  [Space(5)]
  [SerializeField] private string stage;
  public string Stage => stage;
}
