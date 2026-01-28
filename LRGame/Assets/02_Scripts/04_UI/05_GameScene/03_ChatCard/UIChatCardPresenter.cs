using Cysharp.Threading.Tasks;
using DG.Tweening;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using LR.UI.Enum;
using UnityEngine.U2D;

namespace LR.UI.GameScene.ChatCard
{
  public class UIChatCardPresenter : IUIPresenter
  {
    public class Model
    {
      public SpriteAtlas chatCardAtlas;
      public CharacterPositionType positionType;
      public IChatCardPositionGetter chatCardPositionGetter;
      public ChatCardDatasSO chatCardDatasSO;
      public UISO uiSO;

      public Model(SpriteAtlas chatCardAtlas, CharacterPositionType positionType, IChatCardPositionGetter chatCardPositionGetter, ChatCardDatasSO chatCardDatasSO, UISO uiSO)
      {
        this.chatCardAtlas = chatCardAtlas;
        this.positionType = positionType;
        this.chatCardPositionGetter = chatCardPositionGetter;
        this.chatCardDatasSO = chatCardDatasSO;
        this.uiSO = uiSO;
      }
    }

    private readonly Model model;
    private readonly UIChatCardView view;

    private readonly CTSContainer cts = new();

    private ChatCardData data;
    private float duration = 0.0f;
    private SpriteAtlas atlas;

    public UIChatCardPresenter(Model model, UIChatCardView view)
    {
      this.model = model;
      this.view = view;
      view.CanvasGroup.alpha = 0.0f;
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      cts.Cancel();
      cts.Create();
      var localToken = cts.token;

      await UniTask.WhenAll(
        view.ShowAsync(isImmedieately, localToken),
        MoveAsync(model.chatCardPositionGetter.GetPosition(model.positionType), model.uiSO.ChatCardShowDuration, localToken));
      try
      {
        RefreshDuration();

        while (duration > 0.0f)
        {
          localToken.ThrowIfCancellationRequested();
          duration -= Time.deltaTime;
          await UniTask.Yield();
        }

        DeactivateAsync().Forget();
      }
      catch (OperationCanceledException) { }
    }


    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      cts.Cancel();
      cts.Create();
      var localToken = cts.token;
      await UniTask.WhenAll(
        view.HideAsync(isImmedieately, localToken),
        MoveAsync(GetHiddenPosition(), model.uiSO.ChatCardHideDuration, localToken));
    }

    public void SetData(ChatCardData data)
    {
      this.data = data; 
    }

    public async UniTask UpdateViewAsync()
    {
      var portrait = model.chatCardAtlas.GetSprite(data.portraitType.ToString());
      view.PortraitImage.sprite = portrait;
      view.LocalizeStringEvent.SetEntry(data.localizeKey);
      await UniTask.WaitForEndOfFrame();
      LayoutRebuilder.ForceRebuildLayoutImmediate(view.RectTransform);
    }

    public void RefreshDuration()
    {
      duration = model.chatCardDatasSO.Duration;
    }

    public void MoveToHiddenPositionImmedieately()
    {
      view.RectTransform.position = GetHiddenPosition();      
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      if(view)
        view.DestroySelf();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    private Vector2 GetHiddenPosition()
    {
      var targetPosition = model.chatCardPositionGetter.GetPosition(model.positionType);
      return model.positionType switch
      {
        CharacterPositionType.Left => new Vector2(-view.RectTransform.rect.width, targetPosition.y),
        CharacterPositionType.Center => new Vector2(targetPosition.x, targetPosition.y + view.RectTransform.rect.height),
        CharacterPositionType.Right => new Vector2(targetPosition.x + view.RectTransform.rect.width, targetPosition.y),
        _ => throw new NotImplementedException()
      };     
    }

    private async UniTask MoveAsync(Vector2 target, float duration, CancellationToken token)
      => await view.RectTransform.DOMove(target, duration).ToUniTask(TweenCancelBehaviour.Kill, token);
  }
}
