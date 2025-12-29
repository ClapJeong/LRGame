using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using LR.UI.GameScene.Dialogue.Character;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace LR.UI.GameScene.Dialogue
{
  public class UITalkingCharacterPresenter : IUIPresenter
  {
    public enum CharacterType
    {
      Left,
      Center,
      Right,
    }

    public class Model
    {
      public PortraitName portraitNameProvider;
      public CharacterType type;
      public IResourceManager resourceManager;
      public string portraitPath;
      public UIPortraitData portraitData;
      public UITextPresentationData textPresentationData;

      public Model(PortraitName portraitNameProvider, CharacterType type, IResourceManager resourceManager, string portraitPath, UIPortraitData portraitData, UITextPresentationData textPresentationData)
      {
        this.portraitNameProvider = portraitNameProvider;
        this.type = type;
        this.resourceManager = resourceManager;
        this.portraitPath = portraitPath;
        this.portraitData = portraitData;
        this.textPresentationData = textPresentationData;
      }
    }

    private readonly Model model;
    private readonly UITalkingCharacterView view;

    private readonly PortraitController portraitController;
    private readonly TalkingController dialogueController;

    public UITalkingCharacterPresenter(Model model, UITalkingCharacterView view)
    {
      this.model = model;
      this.view = view;

      LoadAllPortraitsAsync().Forget();

      portraitController = new(model.portraitData, view);
      dialogueController = new(view, model.textPresentationData);

      CacheTransparentAsync().Forget();
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmedieately, token);
    }

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      view.dialogueTMP.text = "";
      view.nameTMP.text = "";
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

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();
    

    public async UniTask PlayCharacterDataAsync(DialogueCharacterData data)
    {
      var portrait = await GetPortraitSpriteAsync(data.Portrait);
      portraitController.SetImage(portrait, (PortraitEnum.ChangeType)data.PortraitChangeType);      
      portraitController.PlayAnimation((PortraitEnum.AnimationType)data.PortraitAnimationType);
      portraitController.SetAlpha((PortraitEnum.AlphaType)data.PortraitAlphaType);

      dialogueController.SetName(data.NameKey);
      dialogueController.SetDialogue(data.DialogueKey);
    }

    private async UniTask<Sprite> GetPortraitSpriteAsync(int index)
    {
      var assetName = model.type switch
      {
        CharacterType.Left => model.portraitNameProvider.GetLeftName(index),
        CharacterType.Center => model.portraitNameProvider.GetLeftName(index),
        CharacterType.Right => model.portraitNameProvider.GetLeftName(index),
        _ => throw new NotImplementedException(),
      };
       return await model.resourceManager.LoadAssetAsync<Sprite>(model.portraitPath + assetName);
    }

    private async UniTask LoadAllPortraitsAsync()
    {
      var tasks = new List<UniTask<List<AsyncOperationHandle>>>();
      switch (model.type)
      {
        case CharacterType.Left:
          {
            foreach (var value in Enum.GetValues(typeof(PortraitEnum.Left)))
              tasks.Add(model.resourceManager.LoadAssetsAsync(model.portraitPath + model.portraitNameProvider.GetLeftName((PortraitEnum.Left)value)));
          }
          break;

        case CharacterType.Center:
          {
            foreach (var value in Enum.GetValues(typeof(PortraitEnum.Center)))
              tasks.Add(model.resourceManager.LoadAssetsAsync(model.portraitPath + model.portraitNameProvider.GetCenterName((PortraitEnum.Center)value)));
          }
          break;

        case CharacterType.Right:
          {
            foreach (var value in Enum.GetValues(typeof(PortraitEnum.Right)))
              tasks.Add(model.resourceManager.LoadAssetsAsync(model.portraitPath + model.portraitNameProvider.GetRightName((PortraitEnum.Right)value)));
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
