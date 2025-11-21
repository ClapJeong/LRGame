using UnityEngine;
using UnityEngine.Events;

public class BasePlayerHPController : IPlayerHPController
{
  private readonly PlayerType playerType;
  private readonly PlayerModel model;

  private int hp;
  private UnityEvent<int> onHPChanged = new();

  public BasePlayerHPController(PlayerType playerType, PlayerModel model)
  {
    this.playerType = playerType;
    this.model = model;   

    SetHP(model.so.HP.MaxHP);
  }

  public void SetHP(int value)
  {
    hp = value;
    onHPChanged?.Invoke(hp);
  }

  public void DamageHP(int damage)
  {
    //데미지받고무적도적용해야함
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
}