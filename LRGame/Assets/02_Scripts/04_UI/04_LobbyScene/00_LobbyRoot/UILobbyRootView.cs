using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UILobbyRootView : BaseUIView
  {
    [Header("[ Roots ]")]
    public Transform stageButtonRoot;
    public Transform chapterPanelRoot;
    public Transform indicatorRoot;

    public override UniTask HideAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Hidden;
      return UniTask.CompletedTask;
    }

    public override UniTask ShowAsync(bool isImmediately = false, CancellationToken token = default)
    {
      visibleState = UIVisibleState.Showen;
      return UniTask.CompletedTask;
    }

#if UNITY_EDITOR
    private void Update()
    {
      if(Input.GetKeyDown(KeyCode.F2))
      {
        GlobalManager.instance.GameDataService.SetSelectedStage(0, -1);
        GlobalManager.instance.SceneProvider.LoadSceneAsync(SceneType.Game).Forget();
      }
    }
#endif
  }
}