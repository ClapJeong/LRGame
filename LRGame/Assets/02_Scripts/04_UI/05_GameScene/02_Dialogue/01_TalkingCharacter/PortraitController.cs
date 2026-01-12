using Cysharp.Threading.Tasks;
using DG.Tweening;
using LR.Table.Dialogue;
using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.GameScene.Dialogue.Character
{
  public class PortraitController
  {
    private readonly UIPortraitData portraitData;
    private readonly Image portraitImageA;
    private readonly Image portraitImageB;

    private readonly CTSContainer portriatImageCTS = new();
    private readonly CTSContainer animationCTS = new();
    private readonly CTSContainer alphaCTS = new();

    private Sprite transparent;

    private bool useImageA;
    private bool isImageChanging = false;
    private Image forwardImage;
    private float forwardImageAlpha = 1.0f;

    public PortraitController(UIPortraitData portraitData, Image portraitImageA, Image portraitImageB)
    {
      this.portraitData = portraitData;
      this.portraitImageA = portraitImageA;
      this.portraitImageB = portraitImageB;
    }

    public void SetTransparent(Sprite transparent)
      => this.transparent = transparent;

    public void SetImage(Sprite sprite, PortraitEnum.ChangeType changeType)
    {
      portriatImageCTS.Cancel();
      portriatImageCTS.Create();
      SetImageAsync(sprite, changeType, portriatImageCTS.token).Forget();
    }

    public void PlayAnimation(PortraitEnum.AnimationType animType)
    {

    }

    public void SetAlpha(PortraitEnum.AlphaType alphaType)
    {
      forwardImageAlpha = portraitData.GetAlphaValue(alphaType);
      if (isImageChanging == false && forwardImage != null)
        forwardImage.SetAlpha(forwardImageAlpha);
    }

    private void SwapImageOrder(out Image forwardImage, out Image backwardImage)
    {
      useImageA = !useImageA;

      forwardImage = useImageA ? portraitImageA : portraitImageB;
      backwardImage = useImageA ? portraitImageB : portraitImageA;

      backwardImage.transform.SetAsFirstSibling();
    }

    private async UniTask SetImageAsync(Sprite sprite, PortraitEnum.ChangeType changeType, CancellationToken token)
    {
      SwapImageOrder(out var forwardImage, out var backwardImage);
      this.forwardImage = forwardImage;
      switch (changeType)
      {
        case PortraitEnum.ChangeType.None:
          {
            forwardImage.sprite = sprite;
            backwardImage.sprite = transparent;
            backwardImage.SetAlpha(0.0f);
          }
          break;

        case PortraitEnum.ChangeType.Fade:
          {
            try
            {
              isImageChanging = true;
              forwardImage.sprite = sprite;
              await UniTask.WhenAll(
                forwardImage.DOFade(forwardImageAlpha, portraitData.ChangeFadeDuration).ToUniTask(TweenCancelBehaviour.Kill, token),
                backwardImage.DOFade(0.0f, portraitData.ChangeFadeDuration).ToUniTask(TweenCancelBehaviour.Kill, token));
            }
            catch (OperationCanceledException) { }
            finally
            {
              isImageChanging = false;
              forwardImage.SetAlpha(forwardImageAlpha);
              backwardImage.SetAlpha(0.0f);
            }
          }
          break;
      }
    }
  }
}
