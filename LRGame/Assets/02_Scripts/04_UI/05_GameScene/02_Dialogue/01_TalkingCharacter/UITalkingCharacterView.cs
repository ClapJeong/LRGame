using Cysharp.Threading.Tasks;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;
using UnityEngine.UI;

namespace LR.UI.GameScene.Dialogue
{
  public class UITalkingCharacterView : BaseUIView
  {
    [field: Header("[ Portrait ]")]
    [field: SerializeField] public Animator PortraitAnimator { get; private set; }
    [field: SerializeField] public Image PortraitImageA { get; private set; }    
    [field: SerializeField] public Image PortraitImageB { get; private set; }

    [field: Header("[ Dialogue ]")]
    [field: SerializeField] public CanvasGroup nameCanvasgGroup { get; private set; }
    [field: SerializeField] public TextMeshProUGUI NameTMP { get; private set; }
    [field: SerializeField] public LocalizeStringEvent NameLocalize { get; private set; }
    [field: SerializeField] public TextMeshProUGUI DialogueTMP { get; private set; }
    [field: SerializeField] public LocalizeStringEvent DialogueLocalize { get; private set; }

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(false);
      visibleState = UIVisibleState.Hidden;
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      gameObject.SetActive(true);
      visibleState = UIVisibleState.Showen;
      await UniTask.CompletedTask;
    }
  }
}
