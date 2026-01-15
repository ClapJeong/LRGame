using Cysharp.Threading.Tasks;
using LR.UI.GameScene.ChatCard;
using LR.UI.Enum;
using System;
using UnityEngine;

public class ChatCardService : IChatCardService
{
  private readonly GameObject localManager;
  private readonly ICanvasProvider canvasProvider;
  private readonly IResourceManager resourceManager;
  private readonly IChatCardPositionGetter positionGetter;
  private readonly AddressableKeySO addressableSO;
  private readonly ChatCardDatasSO datasSO;
  private readonly UISO uiSO;

  private UIChatCardPresenter leftPresenter;
  private UIChatCardPresenter centerPresenter;
  private UIChatCardPresenter rightPresenter;

  public ChatCardService(GameObject localManager, ICanvasProvider canvasProvider, IResourceManager resourceManager, IChatCardPositionGetter positionGetter, AddressableKeySO addressableSO, ChatCardDatasSO datasSO, UISO uiSO)
  {
    this.localManager = localManager;
    this.canvasProvider = canvasProvider;
    this.resourceManager = resourceManager;
    this.positionGetter = positionGetter;
    this.addressableSO = addressableSO;
    this.datasSO = datasSO;
    this.uiSO = uiSO;
  }

  public async UniTask PlayChatCardAsync(ChatCardEnum.ID id)
  {
    var positionType = ParsePositionType(id);
    var data = datasSO.GetData(id);
    if(TryGetPresenter(positionType, out var existPresenter))
    {
      existPresenter.SetData(data);

      switch (existPresenter.GetVisibleState())
      {
        case VisibleState.Showing:
          {
            existPresenter.UpdateViewAsync().Forget();            
          }
          break;

        case VisibleState.Showen:
          {
            existPresenter.UpdateViewAsync().Forget();
            existPresenter.RefreshDuration();
          }
          break;

        case VisibleState.Hiding:
          {
            await existPresenter.UpdateViewAsync();
            existPresenter.ActivateAsync().Forget();
          }
          break;

        case VisibleState.Hidden:
          {
            await existPresenter.UpdateViewAsync();
            existPresenter.MoveToHiddenPositionImmedieately();
            existPresenter.ActivateAsync().Forget();
          }
          break;
      }
      existPresenter.SetData(data);
    }
    else
    {
      var presenter = await CreatePresenterAsync(positionType);
      presenter.SetData(data);      
      await presenter.UpdateViewAsync();
      presenter.MoveToHiddenPositionImmedieately();
      presenter.ActivateAsync().Forget();
    }
  }

  private async UniTask<UIChatCardPresenter> CreatePresenterAsync(CharacterPositionType positionType)
  {
    var key = addressableSO.Path.UI + addressableSO.UIName.GetChatCardName(positionType);
    var root = canvasProvider.GetCanvas(RootType.Popup).transform;
    var model = new UIChatCardPresenter.Model(positionType, resourceManager, positionGetter, addressableSO, datasSO, uiSO);
    var view = await resourceManager.CreateAssetAsync<UIChatCardView>(key, root);
    switch (positionType)
    {
      case CharacterPositionType.Left:
        {
          leftPresenter = new(model, view);
          leftPresenter.AttachOnDestroy(localManager);
        }
        return leftPresenter;

      case CharacterPositionType.Center:
        {
          centerPresenter = new(model, view);
          centerPresenter.AttachOnDestroy(localManager);
        }        
        return centerPresenter;

      case CharacterPositionType.Right:
        {
          rightPresenter = new(model, view);
          rightPresenter.AttachOnDestroy(localManager);
        }        
        return rightPresenter;

      default: throw new NotImplementedException();
    }
  }

  private bool TryGetPresenter(CharacterPositionType positionType, out UIChatCardPresenter presenter)
  {
    presenter = positionType switch
    {
      CharacterPositionType.Left => leftPresenter,
      CharacterPositionType.Center => centerPresenter,
      CharacterPositionType.Right => rightPresenter,
      _ => null,
    };

    return presenter != null;
  }

  private CharacterPositionType ParsePositionType(ChatCardEnum.ID type)
    => type switch
    {
      ChatCardEnum.ID.LeftTest => CharacterPositionType.Left,
      ChatCardEnum.ID.CenterTest => CharacterPositionType.Center,
      ChatCardEnum.ID.RightTest => CharacterPositionType.Right,
      ChatCardEnum.ID.LeftTest2 => CharacterPositionType.Left,
      ChatCardEnum.ID.CenterTest2 => CharacterPositionType.Center,
      ChatCardEnum.ID.RightTest2 => CharacterPositionType.Right,
      _ => throw new System.NotImplementedException(),
    };
}
