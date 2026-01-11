using Cysharp.Threading.Tasks;
using DG.Tweening;
using LR.UI.Indicator;
using System;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

namespace LR.UI.Lobby.ChapterPanel
{
  public class StageButtonSetService : IDisposable
  {
    public GameObject FirstGameObject { get; private set; }

    private readonly UISO uiSO;
    private readonly RectTransform rootRectTransform;
    private readonly RectTransform centerPosition;
    private readonly IUIIndicatorPresenter indicator;
    private readonly HorizontalLayoutGroup layoutGroup;
    private readonly UIChapterPanelExitButtonView exitView;

    private readonly CTSContainer stageButtonSetMoveCTS = new();
    private readonly List<UIStageButtonSetPresenter> stageButtonSetPresenters = new();
    private readonly List<int> stageButtonViewIDMap = new();
    private UIStageButtonSetPresenter selectedStageButtonSetPresenter;    

    private float buttonSetViewWidth;

    public StageButtonSetService(UISO uiSO, RectTransform rootRectTransform, RectTransform centerPosition, IUIIndicatorPresenter indicator, HorizontalLayoutGroup layoutGroup, UIChapterPanelExitButtonView exitView)
    {
      this.uiSO = uiSO;
      this.rootRectTransform = rootRectTransform;
      this.centerPosition = centerPosition;
      this.indicator = indicator;
      this.layoutGroup = layoutGroup;
      this.exitView = exitView;
    }

    public void AddMap(UIStageButtonSetPresenter presenter, UIStageButtonSetView view)
    {
      if (stageButtonViewIDMap.Count == 0)
      {
        FirstGameObject = view.gameObject;
        buttonSetViewWidth = view.RectTransform.rect.width;
      }        

      stageButtonSetPresenters.Add(presenter);
      stageButtonViewIDMap.Add(view.GetInstanceID());      
    }

    public async UniTask DeactivateAsync(bool isImmediately, CancellationToken token)
    {
      stageButtonSetMoveCTS.Cancel();
      if (selectedStageButtonSetPresenter != null)
        await selectedStageButtonSetPresenter.DeactivateAsync(isImmediately, token);
    }

    public void Dispose()
    {
      stageButtonSetMoveCTS.Dispose();
    }

    public void OnSelectStageButtonSet(GameObject gameObject)
    {
      selectedStageButtonSetPresenter?.DeactivateAsync().Forget();

      if (gameObject.TryGetComponent<UIStageButtonSetView>(out var stageButtonSetView))
      {        
        var id = stageButtonSetView.GetInstanceID();
        var targetIndex = stageButtonViewIDMap.IndexOf(id);
        selectedStageButtonSetPresenter = stageButtonSetPresenters[targetIndex];
        selectedStageButtonSetPresenter.ActivateAsync().Forget();

        exitView.Selectable.AddNavigation(Direction.Up, stageButtonSetView.Selectable);

        indicator.SetLeftInputGuide(stageButtonSetView.Selectable.navigation);
        indicator.SetRightInputGuide(new Direction[0]);

        stageButtonSetMoveCTS.Cancel();
        stageButtonSetMoveCTS.Create();
        MoveStageButtonSetViewsAsync(targetIndex, stageButtonSetMoveCTS.token).Forget();
      }
    }

    public void InitializeFirstPosition()
    {
      MoveStageButtonSetViewsAsync(0, default).Forget();
    }

    private async UniTask MoveStageButtonSetViewsAsync(int targetIndex, CancellationToken token)
    {
      var interval = layoutGroup.spacing;
      var targetLength = buttonSetViewWidth * 0.5f + (buttonSetViewWidth + interval) * targetIndex;

      await rootRectTransform.DOAnchorPos(centerPosition.anchoredPosition + (-targetLength) * Vector2.right, uiSO.StageButtonMoveDuration)
        .ToUniTask(TweenCancelBehaviour.Kill, token);
    }
  }
}
