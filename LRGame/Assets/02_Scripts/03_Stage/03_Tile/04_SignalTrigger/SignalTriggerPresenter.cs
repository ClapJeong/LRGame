using LR.Stage.Player;
using LR.Table.TriggerTile;
using System;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.Stage.TriggerTile
{
  public class SignalTriggerPresenter : ITriggerTilePresenter
  {
    public class Model
    {
      public SignalTriggerData data;

      public TableContainer table;
      public ISignalKeyRegister signalKeyRegister;
      public ISignalConsumer signalConsumer;
      public IPlayerGetter playerGetter;

      public Model(SignalTriggerData data, TableContainer table, ISignalKeyRegister signalKeyRegister, ISignalConsumer signalConsumer, IPlayerGetter playerGetter)
      {
        this.data = data;
        this.table = table;
        this.signalKeyRegister = signalKeyRegister;
        this.signalConsumer = signalConsumer;
        this.playerGetter = playerGetter;
      }
    }

    private readonly Model model;
    private readonly SignalTriggerView view;

    private bool enable;
    private bool isSignalAcquired = false;
    private IDisposable rotatingDisposable;

    public SignalTriggerPresenter(Model model, SignalTriggerView view)
    {
      this.model = model;
      this.view = view;

      view.SetAlpha(model.data.DeactivateAlpha);
      view.SubscribeOnEnter(OnEnter);
      view.SubscribeOnExit(OnExit);
      RegisterKeys();
    }

    public void Enable(bool enable)
    {
      this.enable = enable; 
    }

    public void Restart()
    {
      Enable(true);
      isSignalAcquired = false;
      view.SetAlpha(model.data.DeactivateAlpha);
      rotatingDisposable?.Dispose();
      view.transform.eulerAngles = Vector3.zero;
    }

    private void RegisterKeys()
    {
      if(view.IsEnterKeyExist)
        model.signalKeyRegister.RegisterKey(view.Key, view.GetHashCode(), view.SignalLife);
    }

    private void OnEnter(Collider2D collider2D)
    {
      if (!enable ||
          !collider2D.CompareTag(Tag.PlayerTileTriggerCollider) ||
          !view.IsEnterKeyExist)
        return;

      OnSignalSuccess();
    }

    private void OnSignalSuccess()
    {
      model.signalConsumer.AcquireSignal(view.Key, view.GetHashCode());
      isSignalAcquired = true;
      view.SetAlpha(model.data.ActivateAlpha);

      switch (view.SignalLife)
      {
        case Enum.SignalLife.OnlyActivate:
          {
            Enable(false);
          }
          break;

        case Enum.SignalLife.ActivateAndDeactivate:
          {
            rotatingDisposable = view
              .gameObject
              .UpdateAsObservable()
              .Subscribe(_ =>
              {
                view.IconTransform.Rotate(-360.0f * Time.deltaTime * model.data.RotateSpeed * Vector3.forward);
              });
          }
          break;
      }
    }

    private void OnExit(Collider2D collider2D)
    {
      if (!enable ||
          !isSignalAcquired ||
          !collider2D.CompareTag(Tag.PlayerTileTriggerCollider) ||
          !view.IsEnterKeyExist)
        return;

      switch (view.SignalLife)
      {
        case Enum.SignalLife.OnlyActivate:
          {
            
          }
          break;

        case Enum.SignalLife.ActivateAndDeactivate:
          {
            model.signalConsumer.ReleaseSignal(view.Key, view.GetHashCode());
            rotatingDisposable?.Dispose();
            view.transform.eulerAngles = Vector3.zero;
            view.SetAlpha(model.data.DeactivateAlpha);
          }
          break;
      }
    }
  }
}
