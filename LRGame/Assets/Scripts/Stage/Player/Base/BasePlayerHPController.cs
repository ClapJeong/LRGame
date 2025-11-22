using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class BasePlayerHPController : IPlayerHPController
{
  private readonly PlayerType playerType;
  private readonly PlayerModel model;
  private readonly ISpriteRendererView spriteRenderer;

  private int hp;
  private bool isInvincible;

  private UnityEvent<int> onHPChanged = new();

  public BasePlayerHPController(PlayerType playerType, PlayerModel model, ISpriteRendererView spriteRenderer)
  {
    this.playerType = playerType;
    this.model = model;   
    this.spriteRenderer = spriteRenderer;

    SetHP(model.so.HP.MaxHP);
  }

  public void SetHP(int value)
  {
    hp = value;
    onHPChanged?.Invoke(hp);
  }

  public void DamageHP(int damage)
  {
    PlayInvincible(model.so.HP.InvincibleDuration).Forget();
    hp = Mathf.Max(0, hp - damage);
    onHPChanged?.Invoke(hp);

    if (hp <= 0)
      OnHPZero();
  }

  public void RestoreHP(int value)
  {
    hp = Mathf.Min(model.maxHP, hp + value);
    onHPChanged?.Invoke(hp);
  }

  public void SubscribeOnHPChanged(UnityAction<int> onHPChanged)
  {
    this.onHPChanged.AddListener(onHPChanged);
  }

  public void UnsubscribeOnHPChanged(UnityAction<int> onHPChanged)
  {
    this.onHPChanged.RemoveListener(onHPChanged);
  }

  private void OnHPZero()
  {
    IStageController stageController = LocalManager.instance.StageManager;
    switch (playerType)
    {
      case PlayerType.Left:
        stageController.OnLeftFailed();
        break;

      case PlayerType.Right:
        stageController.OnRightFailed();
        break;
    }
  }

  public void Dispose()
  {
    
  }

  public bool IsInvincible()
    => isInvincible;

  public async UniTask PlayInvincible(float duration, UnityAction onFinished = null, CancellationToken token = default)
  {
    isInvincible = true;
    try
    {
      var time = 0.0f;
      var interval = 0.2f;
      while (time < duration)
      {
        token.ThrowIfCancellationRequested();

        var blinkCount =(int)(time / interval);
        if (blinkCount % 2 == 0)
          spriteRenderer.SetAlpha(model.so.HP.InvincibleBlinkAlphaMax);
        else
          spriteRenderer.SetAlpha(model.so.HP.InvincibleBlinkAlphaMin);

        time += Time.deltaTime;
        await UniTask.Yield(PlayerLoopTiming.Update);
      }
      
    }
    catch (OperationCanceledException) { }
    finally
    {
      spriteRenderer.SetAlpha(1.0f);
      isInvincible = false;
    }
  }

}