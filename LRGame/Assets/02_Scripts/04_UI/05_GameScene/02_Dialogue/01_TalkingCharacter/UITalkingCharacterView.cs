using Cysharp.Threading.Tasks;
using Febucci.TextAnimatorForUnity;
using Febucci.TextAnimatorForUnity.TextMeshPro;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;
using LR.UI.Enum;

namespace LR.UI.GameScene.Dialogue
{
  public class UITalkingCharacterView : BaseUIView
  {
    [field: Header("[ Portrait ]")]
    [field: SerializeField] public Animator PortraitAnimator { get; private set; }
    [field: SerializeField] public Image PortraitImageA { get; private set; }    
    [field: SerializeField] public Image PortraitImageB { get; private set; }

    [field: Header("[ Dialogue ]")]
    [field: SerializeField] public GameObject DialogueBackground {  get; private set; }
    [field: SerializeField] public CanvasGroup NameCanvasgGroup { get; private set; }
    [field: SerializeField] public TextMeshProUGUI NameTMP { get; private set; }
    [field: SerializeField] public LocalizeStringEvent NameLocalize { get; private set; }
    [field: SerializeField] public TextMeshProUGUI DialogueTMP { get; private set; }
    [field: SerializeField] public LocalizeStringEvent DialogueLocalize { get; private set; }
    [field: SerializeField] public TextAnimator_TMP AnimatorTMP { get; private set;  }
    [field: SerializeField] public TypewriterComponent Typewriter { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(false);
      visibleState = VisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = VisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}
