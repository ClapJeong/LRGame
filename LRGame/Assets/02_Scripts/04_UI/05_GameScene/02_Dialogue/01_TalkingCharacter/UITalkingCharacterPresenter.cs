using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using LR.UI.Enum;
using LR.UI.GameScene.Dialogue.Character;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.U2D;
using static DialogueDataEnum;

namespace LR.UI.GameScene.Dialogue
{
  public class UITalkingCharacterPresenter : IUIPresenter
  {
    public class Model
    {
      public AddressableKeySO AddressableKeySO;
      public CharacterPositionType positionType;
      public IResourceManager resourceManager;
      public UIPortraitData portraitData;
      public UITextPresentationData textPresentationData;

      public Model(AddressableKeySO addressableKeySO, CharacterPositionType positionType, IResourceManager resourceManager, UIPortraitData portraitData, UITextPresentationData textPresentationData)
      {
        AddressableKeySO = addressableKeySO;
        this.positionType = positionType;
        this.resourceManager = resourceManager;
        this.portraitData = portraitData;
        this.textPresentationData = textPresentationData;
      }
    }

    private readonly Model model;
    private readonly UITalkingCharacterView view;

    private readonly PortraitController portraitController;
    private readonly TextController textController;
    private SpriteAtlas atlas;

    public UITalkingCharacterPresenter(Model model, UITalkingCharacterView view)
    {
      this.model = model;
      this.view = view;

      LoadAtlasAsync()
        .ContinueWith(()=>
        {
          CacheTransparent();
        });

      portraitController = new(
        model.positionType,
        model.portraitData, 
        view.PortraitAnimator, 
        view.PortraitImageA, 
        view.PortraitImageB);
      textController = new(
        model.textPresentationData, 
        view.DialogueBackground,
        view.NameCanvasgGroup, 
        view.NameLocalize, 
        view.DialogueLocalize, 
        view.DialogueTMP,
        view.AnimatorTMP,
        view.Typewriter);      
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmedieately, token);
    }

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      view.DialogueTMP.text = "";
      view.NameTMP.text = "";
      await view.HideAsync(isImmedieately, token);
      await UniTask.CompletedTask;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      ReleaseAtlas();
      if (view)
        view.DestroySelf();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();
    
    public void ClearView()
    {
      portraitController.Clear();

      textController.ClearName();
      textController.ClearText();      
    }

    public async UniTask PlayCharacterDataAsync(DialogueCharacterData data)
    {
      var portrait = GetPortraitSprite(data.Portrait);
      portraitController.SetImage(portrait, (DialogueDataEnum.Portrait.ChangeType)data.PortraitChangeType);      
      portraitController.PlayAnimation((DialogueDataEnum.Portrait.AnimationType)data.PortraitAnimationType);
      portraitController.SetAlpha((DialogueDataEnum.Portrait.AlphaType)data.PortraitAlphaType);

      textController.SetName(data.NameKey);
      await textController.SetDialogueAsync(data.DialogueKey);
    }

    public void CompleteDialogueImmedieately()
      => textController.CompleteDialogueImmediately();

    public void ClearText()
      => textController.ClearText();

    private Sprite GetPortraitSprite(int index)
    {
      var spriteName = model.positionType switch
      {
        CharacterPositionType.Left => ((DialogueDataEnum.Portrait.Left)index).ToString(),
        CharacterPositionType.Center => ((DialogueDataEnum.Portrait.Center)index).ToString(),
        CharacterPositionType.Right => ((DialogueDataEnum.Portrait.Right)index).ToString(),
        _ => throw new NotImplementedException(),
      };

      return atlas.GetSprite(spriteName);
    }

    private async UniTask LoadAtlasAsync()
    {
      atlas = await model.resourceManager.LoadAssetAsync<SpriteAtlas>(
        model.AddressableKeySO.Path.SpriteAtlas +
        model.AddressableKeySO.AtlasName.GetDialoguePortrait(model.positionType));
    }

    private void ReleaseAtlas()
    {
      model.resourceManager.ReleaseAsset(
        model.AddressableKeySO.Path.SpriteAtlas +
        model.AddressableKeySO.AtlasName.GetDialoguePortrait(model.positionType));
    }

    private void CacheTransparent()
    {
      var transparent = GetPortraitSprite(0);
      portraitController.SetTransparent(transparent);
    }
  }
}
