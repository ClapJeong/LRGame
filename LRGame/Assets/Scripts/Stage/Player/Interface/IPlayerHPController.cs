using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public interface IPlayerHPController: IDisposable
{
  public void SetHP(int value);

  public void DamageHP(int damage);

  public void RestoreHP(int value);

  public void SubscribeOnHPChanged(UnityAction<int> onHPChanged);

  public void UnsubscribeOnHPChanged(UnityAction<int> onHPChanged);

  public bool IsInvincible();

  public UniTask PlayInvincible(float duration, UnityAction onFinished = null, CancellationToken token = default);
}
