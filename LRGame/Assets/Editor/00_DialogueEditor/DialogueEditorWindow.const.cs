
public partial class DialogueEditorWindow
{
  private const string FolderPath = "Assets/08_DialogueData/";
  private const string FileNameFormat = "{0}_{1}.json";
  private const string NewDataSetName = "newName";
  private const string DataSubNameTextField = "DataSubName";
  private const string LeftPortraitPath = "Assets/01_Art/00_Sprites/00_Portrait/00_Left/";
  private const string RightPortraitPath = "Assets/01_Art/00_Sprites/00_Portrait/01_Right/";
  private const string CenterPortraitPath = "Assets/01_Art/00_Sprites/00_Portrait/02_Center/";
  private const float PortraitWidth = 100.0f;
  private const float PortraitHeight = 100.0f;
  private string GetPortraitPath(CharacterPositionType positionType)
    => positionType switch
    {
      CharacterPositionType.Left => LeftPortraitPath,
      CharacterPositionType.Center => CenterPortraitPath,
      CharacterPositionType.Right => RightPortraitPath,
      _ => throw new System.NotImplementedException(),
    };
}
