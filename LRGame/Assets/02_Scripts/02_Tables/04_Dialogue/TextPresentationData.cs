using System;
using UnityEngine;

namespace LR.Table.Dialogue
{
  [System.Serializable]
  public class TextPresentationData
  {
    [field: SerializeField] public float CharacterInterval { get; private set; }
    [field: SerializeField] public float SkipInputDuration { get; private set; }
    [field: SerializeField] public float InputPerformedAlpha { get; private set; }
    [field: SerializeField] public float InputCanceledAlpha { get; private set; }
  }
}
