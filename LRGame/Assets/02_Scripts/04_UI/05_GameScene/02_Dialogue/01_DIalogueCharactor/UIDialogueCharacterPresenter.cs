using Cysharp.Threading.Tasks;
using LR.Table.Dialogue;
using LR.UI.GameScene.Dialogue.Character;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace LR.UI.GameScene.Dialogue
{
  public class UIDialogueCharacterPresenter : IUIPresenter
  {
    public enum CharacterType
    {
      Left,
      Center,
      Right,
    }

    public class Model
    {
      public CharacterType type;
      public IResourceManager resourceManager;
      public string portraitPath;
      public PortraitData portraitData;
      public TextPresentationData textPresentationData;

      public Model(CharacterType type, IResourceManager resourceManager, string portraitPath, PortraitData portraitData, TextPresentationData textPresentationData)
      {
        this.type = type;
        this.resourceManager = resourceManager;
        this.portraitPath = portraitPath;
        this.portraitData = portraitData;
        this.textPresentationData = textPresentationData;
      }
    }

    private readonly Model model;
    private readonly UIDialogueCharacterView view;

    private readonly PortraitController portraitController;
    private readonly DialogueController dialogueController;

    public UIDialogueCharacterPresenter(Model model, UIDialogueCharacterView view)
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
        CharacterType.Left => ((PortraitEnum.Left)index).ToString(),
        CharacterType.Center => ((PortraitEnum.Center)index).ToString(),
        CharacterType.Right => ((PortraitEnum.Right)index).ToString(),
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
            foreach (var name in Enum.GetNames(typeof(PortraitEnum.Left)))
              tasks.Add(model.resourceManager.LoadAssetsAsync(model.portraitPath + name));
          }
          break;

        case CharacterType.Center:
          {
            foreach (var name in Enum.GetNames(typeof(PortraitEnum.Center)))
              tasks.Add(model.resourceManager.LoadAssetsAsync(model.portraitPath + name));
          }
          break;

        case CharacterType.Right:
          {
            foreach (var name in Enum.GetNames(typeof(PortraitEnum.Right)))
              tasks.Add(model.resourceManager.LoadAssetsAsync(model.portraitPath + name));
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
