using UnityEngine;
using UnityEngine.Events;

public interface IPlayerHPController 
{
  public void SetHP(int value);

  public void DamageHP(int damage);

  public void RestoreHP(int value);

  public void SubscribeOnHPChanged(UnityAction<int> onHPChanged);

  public void UnsubscribeOnHPChanged(UnityAction<int> onHPChanged);
}
