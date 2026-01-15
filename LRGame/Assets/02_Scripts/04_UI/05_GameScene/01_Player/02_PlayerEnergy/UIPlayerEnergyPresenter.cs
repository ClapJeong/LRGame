using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using LR.UI.Enum;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerEnergyPresenter : IUIPresenter
  {
    public class Model
    {
      public IPlayerEnergyProvider energyProvider;
      public PlayerEnergyData playerEnergyData;

      public Model(IPlayerEnergyProvider energyProvider, PlayerEnergyData playerEnergyData)
      {
        this.energyProvider = energyProvider;
        this.playerEnergyData = playerEnergyData;
      }
    }

    private readonly Model model;
    private readonly UIPlayerEnergyView view;

    private IDisposable viewUpdateObserver;

    public UIPlayerEnergyPresenter(Model model, UIPlayerEnergyView view)
    {
      this.model = model;
      this.view = view;

      SubscribeView();
    }

    public async UniTask ActivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.ShowAsync(isImmedieately, token);
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.AttachDisposable(this);

    public async UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      await view.HideAsync(isImmedieately, token);
    }

    public void Dispose()
    {
      viewUpdateObserver.Dispose();
      if (view)
        view.DestroySelf();
    }

    public VisibleState GetVisibleState()
      => view.GetVisibleState();

    private void SubscribeView()
    {
      viewUpdateObserver = view
        .UpdateAsObservable()
        .Subscribe(_ =>
        {
          var normalized = model.energyProvider.CurrentEnergy / model.playerEnergyData.MaxEnergy;
          view.FillImage.SetFillAmount(normalized);
        });
    }
  }
}