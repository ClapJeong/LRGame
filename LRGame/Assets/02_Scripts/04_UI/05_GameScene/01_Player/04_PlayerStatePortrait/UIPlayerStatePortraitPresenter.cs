using Cysharp.Threading.Tasks;
using LR.UI.Enum;
using System;
using System.Threading;
using UnityEngine;
using LR.UI.GameScene.Player.PlayerPortrait;
using LR.Stage.Player;
using System.Text;
using LR.Stage.Player.Enum;
using UniRx.Triggers;
using UniRx;
using DG.Tweening;
using UnityEngine.U2D;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerStatePortraitPresenter : IUIPresenter
  {
    public class Model
    {
      public IPlayerStateProvider stateProvider;
      public IPlayerEnergySubscriber energySubscriber;
      public IPlayerEnergyProvider energyProvider;
      public UISO uiSO;
      public AddressableKeySO addressableKeySO;
      public PlayerType playerType;
      public IResourceManager resourceManager;

      public Model(
        IPlayerStateProvider stateProvider,
        IPlayerEnergySubscriber energySubscriber,
        IPlayerEnergyProvider energyProvider,
        UISO uiSO, 
        AddressableKeySO addressableKeySO, 
        PlayerType playerType, 
        IResourceManager resourceManager)
      {
        this.stateProvider = stateProvider;
        this.energySubscriber = energySubscriber;
        this.energyProvider = energyProvider;
        this.uiSO = uiSO;
        this.addressableKeySO = addressableKeySO;
        this.playerType = playerType;
        this.resourceManager = resourceManager;
      }
    }

    private readonly Model model;
    private readonly UIPlayerStatePortraitView view;

    private readonly CTSContainer damagedCTS = new();
    private readonly Vector2 originPortriatAnchoredPos;
    private SpriteAtlas atlas;
    private IDisposable viewUpdateDisposable;
    private Portrait prevPortrait;
   
    public UIPlayerStatePortraitPresenter(Model model, UIPlayerStatePortraitView view)
    {
      this.model = model;
      this.view = view;

      viewUpdateDisposable =
        view
        .UpdateAsObservable()
        .Subscribe(_ =>
        {
          UpdatePortrait();
        });
      model.energySubscriber.SubscribeValueEvent(IPlayerEnergySubscriber.ValueEvent.Damaged, OnDamaged);
      originPortriatAnchoredPos = view.PortraitImage.rectTransform.anchoredPosition;
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      if (atlas == null)
        await LoadAtlasAsync();

      ChangePortrait(Portrait.Idle);
      await UniTask.CompletedTask;
    }

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await UniTask.CompletedTask;
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public void Dispose()
    {
      ReleaseAtlas();
      damagedCTS.Dispose();
      viewUpdateDisposable.Dispose();
      model.energySubscriber.UnsubscribeValueEvent(IPlayerEnergySubscriber.ValueEvent.Damaged, OnDamaged);
      if (view)
        view.DestroySelf();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    private void UpdatePortrait()
    {
      var portrait = model.stateProvider.GetCurrentState() switch
      {
        PlayerState.Idle => GetIdlePortrait(),
        PlayerState.Move => GetIdlePortrait(),
        PlayerState.Stun => Portrait.Stun,
        PlayerState.Inputting => Portrait.Inputting,
        PlayerState.Freeze => Portrait.Freeze,
        PlayerState.Clear => Portrait.Clear,

        _ => throw new NotImplementedException(),
      };

      if (portrait != prevPortrait)
        ChangePortrait(portrait);
    }

    private void ChangePortrait(Portrait portrait)
    {
      view.PortraitImage.sprite = atlas.GetSprite(portrait.ToString());
      prevPortrait = portrait;
    }

    private async UniTask LoadAtlasAsync()
    {
      atlas = await model.resourceManager.LoadAssetAsync<SpriteAtlas>(
        model.addressableKeySO.Path.SpriteAtlas +
        model.addressableKeySO.AtlasName.GetStatePortrait(model.playerType));
    }

    private void ReleaseAtlas()
    {
      model.resourceManager.ReleaseAsset(
        model.addressableKeySO.Path.SpriteAtlas +
        model.addressableKeySO.AtlasName.GetStatePortrait(model.playerType));
    }

    private Portrait GetIdlePortrait()
    {
      var energyNormalized = model.energyProvider.CurrentNormalized;
      if (energyNormalized <= 0.0f)
        return Portrait.Exhausted;
      else if (energyNormalized <= model.uiSO.PortraitLowEnergy)
        return Portrait.Low;
      else
        return Portrait.Idle;
    }

    private void OnDamaged(float _)
    {
      damagedCTS.Cancel();
      damagedCTS.Create();
      var token = damagedCTS.token;

      view
        .PortraitImage
        .rectTransform
        .DOShakeAnchorPos(model.uiSO.DamagedPortraitShakeDuration, model.uiSO.DamagedPortraitShakeStrengh, model.uiSO.DamagedPortraitShakeVibrato, 360.0f)
        .OnComplete(() =>
        {
          view.PortraitImage.rectTransform.anchoredPosition = originPortriatAnchoredPos;
        })
        .ToUniTask(TweenCancelBehaviour.Complete, token)
        .Forget();
    }
  }
}
