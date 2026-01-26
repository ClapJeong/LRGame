using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using LR.UI.Enum;
using LR.UI.GameScene.Dialogue.Character;
using System;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using static DialogueDataEnum;

namespace LR.UI.GameScene.Dialogue
{
  public class UITalkingCharacterPresenter : IUIPresenter
  {
    public class Model
    {
      public PortraitName portraitNameProvider;
      public CharacterPositionType positionType;
      public IResourceManager resourceManager;
      public string portraitPath;
      public UIPortraitData portraitData;
      public UITextPresentationData textPresentationData;

      public Model(PortraitName portraitNameProvider, CharacterPositionType positionType, IResourceManager resourceManager, string portraitPath, UIPortraitData portraitData, UITextPresentationData textPresentationData)
      {
        this.portraitNameProvider = portraitNameProvider;
        this.positionType = positionType;
        this.resourceManager = resourceManager;
        this.portraitPath = portraitPath;
        this.portraitData = portraitData;
        this.textPresentationData = textPresentationData;
      }
    }

    private readonly Model model;
    private readonly UITalkingCharacterView view;

    private readonly PortraitController portraitController;
    private readonly TextController textController;

    public UITalkingCharacterPresenter(Model model, UITalkingCharacterView view)
    {
      this.model = model;
      this.view = view;

      LoadAllPortraitsAsync().Forget();

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

      CacheTransparentAsync().Forget();
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
      var portrait = await GetPortraitSpriteAsync(data.Portrait);
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

    private async UniTask<Sprite> GetPortraitSpriteAsync(int index)
    {
      var assetName = model.positionType switch
      {
        CharacterPositionType.Left => model.portraitNameProvider.GetLeftName(index),
        CharacterPositionType.Center => model.portraitNameProvider.GetLeftName(index),
        CharacterPositionType.Right => model.portraitNameProvider.GetLeftName(index),
        _ => throw new NotImplementedException(),
      };
       return await model.resourceManager.LoadAssetAsync<Sprite>(model.portraitPath + assetName);
    }

    private async UniTask LoadAllPortraitsAsync()
    {
      var tasks = new List<UniTask<List<AsyncOperationHandle>>>();
      switch (model.positionType)
      {
        case CharacterPositionType.Left:
          {
            foreach (var value in System.Enum.GetValues(typeof(DialogueDataEnum.Portrait.Left)))
              tasks.Add(model.resourceManager.LoadAssetsAsync(model.portraitPath + model.portraitNameProvider.GetLeftName((DialogueDataEnum.Portrait.Left)value)));
          }
          break;

        case CharacterPositionType.Center:
          {
            foreach (var value in System.Enum.GetValues(typeof(DialogueDataEnum.Portrait.Center)))
              tasks.Add(model.resourceManager.LoadAssetsAsync(model.portraitPath + model.portraitNameProvider.GetCenterName((DialogueDataEnum.Portrait.Center)value)));
          }
          break;

        case CharacterPositionType.Right:
          {
            foreach (var value in System.Enum.GetValues(typeof(DialogueDataEnum.Portrait.Right)))
              tasks.Add(model.resourceManager.LoadAssetsAsync(model.portraitPath + model.portraitNameProvider.GetRightName((DialogueDataEnum.Portrait.Right)value)));
          }
          break;
      }
      await UniTask.WhenAll(tasks);
    }

    private async UniTask CacheTransparentAsync()
    {
      var transparent = await GetPortraitSpriteAsync(0);
      portraitController.SetTransparent(transparent);
    }
  }
}
