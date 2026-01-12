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
    [Header("[ Portrait ]")]
    public Image portraitImageA;
    public Image portraitImageB;

    [Header("[ Dialogue ]")]
    public GameObject nameRoot;
    public TextMeshProUGUI nameTMP;
    public LocalizeStringEvent nameLocalize;
    public TextMeshProUGUI dialogueTMP;
    public LocalizeStringEvent dialogueLocalize;

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
