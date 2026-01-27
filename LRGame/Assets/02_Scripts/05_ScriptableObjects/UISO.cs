using LR.Table.Input;
using UnityEngine;

[CreateAssetMenu(fileName = "UISO", menuName = "SO/UI")]
public class UISO : ScriptableObject
{
  [field: SerializeField] public UIInputActionPaths InputPaths {  get; private set; }

  [field: Space(5)]
  [field: SerializeField] public float IndicatorDuration {  get; private set; }
  [field: Space(5)]
  [field: SerializeField] public float ProgressSubmitDuration {  get; private set; }
  [field: Space(5)]
  [field: SerializeField] public float LoadingFaceDuraton { get; private set; }
  [field: Space(5)]
  [field: SerializeField] public float ChatCardShowDuration { get; private set; }
  [field: SerializeField] public float ChatCardHideDuration { get; private set; }

  [field: Header("[ Lobby ]")]
  [field: SerializeField] public float LobbyPanelMoveDuration { get; private set; }
  [field: SerializeField] public Vector3 StageButtonShowScale { get; private set; }
  [field: SerializeField] public Vector3 StageButtonHideScale { get; private set; }
  [field: SerializeField] public float StageButtonMoveDuration { get; private set; }

  [field: Space(5)]
  [field: SerializeField] public float SliderAmount {  get; private set; }

  [field: Header("[ Stage ]")]
  [field: SerializeField] public float StageUIMoveDefaultDuration {  get; private set; }
  [field: SerializeField] public float BeginShowDuration { get; private set; }
  [field: SerializeField] public float BeginHideDuration { get; private set; }
  [field: SerializeField] public float RestartDelay { get; private set; }
  [field: SerializeField] public float RestartUIFadeDuration {  get; private set; }
  [field: SerializeField] public float ScoreFillMaxDuration { get; private set;  }
  [field: SerializeField] public float ScoreShowDuration {  get; private set; }
  [field: SerializeField] public float ScoreHideDuration { get; private set; }
  [field: SerializeField] public float SucessUIDelay { get; private set; }

  [field: Header("[ Player ]")]
  [field: SerializeField][field: Range(0.0f, 1.0f)] public float PortraitLowEnergy { get; private set; }
  [field: SerializeField] public float DamagedEnergyUIDuration { get; private set; }
  [field: Header("[ Dialogue ]")]
  [field: SerializeField] public float DialogueRootShowDuratoin {  get; private set; }
  [field: SerializeField] public float DialogueRootHideDuratoin { get; private set; }
  [field: SerializeField] public float SelectionShowDuration {  get; private set; }
  [field: SerializeField] public float SelectionHideDuration { get; private set; }  
}