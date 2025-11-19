using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UniRx;
using UniRx.Triggers;
using UnityEngine;

namespace LR.UI.GameScene.Player
{
  public class UIPlayerHPPresenter : IUIPresenter
  {
    public class Model
    {
      public int leftMaxHP;
      public int rightMaxHP;

      public Model(int leftMaxHP, int rightMaxHP)
      {
        this.leftMaxHP = leftMaxHP;
        this.rightMaxHP = rightMaxHP;
      }
    }

    private readonly Model model;
    private readonly IPlayerHPController leftHPController;
    private readonly UIPlayerHPViewContainer leftViewContainer;
    private readonly IPlayerHPController rightHPController;
    private readonly UIPlayerHPViewContainer rightViewContainer;

    public UIPlayerHPPresenter(
      Model model, 
      UIPlayerHPViewContainer leftViewContainer,
      IPlayerHPController leftHPController,
      UIPlayerHPViewContainer rightViewContainer,
      IPlayerHPController rightHPController)
    {
      this.model = model;
      this.leftViewContainer = leftViewContainer;
      this.leftHPController = leftHPController;
      this.rightViewContainer = rightViewContainer;
      this.rightHPController = rightHPController;

      InitializeHPObjects();
      SubscribePresenters();
    }

    public IDisposable AttachOnDestroy(GameObject target)
      => target.OnDestroyAsObservable().Subscribe(_ => Dispose());

    public void Dispose()
    {
      GlobalManager.instance.UIManager.Remove(this);
      UnsubscribePresenters();
    }

    public UIVisibleState GetVisibleState()
    {
      throw new NotImplementedException();
    }

    public UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }

    public void SetVisibleState(UIVisibleState visibleState)
    {
      throw new NotImplementedException();
    }

    public UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      return UniTask.CompletedTask;
    }


    private void InitializeHPObjects()
    {
      for(int i=0;i<leftViewContainer.hpObjects.Count;i++)
      {
        var isActive = i < model.leftMaxHP;
        leftViewContainer.hpObjects[i].SetActive(isActive);
      }

      for (int i = 0; i < rightViewContainer.hpObjects.Count; i++)
      {
        var isActive = i < model.rightMaxHP;
        rightViewContainer.hpObjects[i].SetActive(isActive);
      }
    }

    private void SubscribePresenters()
    {
      leftHPController.SubscribeOnHPChanged(OnLeftHPChanged);
      rightHPController.SubscribeOnHPChanged(OnRightHPChanged);
    }

    private void UnsubscribePresenters()
    {
      leftHPController?.UnsubscribeOnHPChanged(OnLeftHPChanged);
      rightHPController?.UnsubscribeOnHPChanged(OnRightHPChanged);
    }

    private void OnLeftHPChanged(int currentHp)
    {
      for (int i = 0; i < leftViewContainer.hpObjects.Count; i++)
      {
        var isActive = i < currentHp;
        leftViewContainer.hpObjects[i].SetActive(isActive);
      }
    }

    private void OnRightHPChanged(int currentHp)
    {
      for (int i = 0; i < rightViewContainer.hpObjects.Count; i++)
      {
        var isActive = i < currentHp;
        rightViewContainer.hpObjects[i].SetActive(isActive);
      }
    }
  }
}