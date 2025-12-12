using Cysharp.Threading.Tasks;
using LR.Stage.Player;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerEnergyPresenter : IUIPresenter
  {
    public class Model
    {
      public IPlayerEnergyController playerEnergyController;
      public PlayerEnergyData playerEnergyData;

      public Model(IPlayerEnergyController playerEnergyController, PlayerEnergyData playerEnergyData)
      {
        this.playerEnergyController = playerEnergyController;
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

    public UniTask DeactivateAsync(bool isImmedieately = false, CancellationToken token = default)
    {
      throw new NotImplementedException();
    }

    public void Dispose()
    {
      viewUpdateObserver.Dispose();
      if (view)
        view.DestroySelf();
    }

    public UIVisibleState GetVisibleState()
      => view.GetVisibleState();

    private void SubscribeView()
    {
      viewUpdateObserver = view
        .UpdateAsObservable()
        .Subscribe(_ =>
        {
          var value = model.playerEnergyController.GetCurrentEnergy() / model.playerEnergyData.MaxEnergy;
          view.fillImageView.SetFillAmount(value);
        });
    }
  }
}