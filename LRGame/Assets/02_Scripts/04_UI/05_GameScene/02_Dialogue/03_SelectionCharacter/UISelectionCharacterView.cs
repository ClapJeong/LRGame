using Cysharp.Threading.Tasks;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace LR.UI.GameScene.Dialogue
{
  public class UISelectionCharacterView : BaseUIView
  {
    public LocalizeStringEvent upLocalize;
    public LocalizeStringEvent rightLocalize;
    public LocalizeStringEvent downLocalize;
    public LocalizeStringEvent leftLocalize;
    public RectTransform idleRect;
    public RectTransform outlineRect;

    public override async UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hidden;
      gameObject.SetActive(false);
      await UniTask.CompletedTask;
    }

    public override async UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showen;
      outlineRect.position = GetDirectionPosition(Direction.Space);;
      gameObject.SetActive(true);
      await UniTask.CompletedTask;
    }

    public Vector3 GetDirectionPosition(Direction direction)
      => direction switch
      {
        Direction.Up => upLocalize.GetComponent<RectTransform>().GetCenterPosition(),
        Direction.Down => downLocalize.GetComponent<RectTransform>().GetCenterPosition(),
        Direction.Left => leftLocalize.GetComponent<RectTransform>().GetCenterPosition(),
        Direction.Right => rightLocalize.GetComponent<RectTransform>().GetCenterPosition(),
        Direction.Space => idleRect.GetCenterPosition(),
        _ => throw new NotImplementedException()
      };
  }
}
