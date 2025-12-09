using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

namespace LR.UI.Lobby
{
  public class UILobbyViewContainer : MonoBehaviour
  {
    public BaseGameObjectView BaseGameObjectView;
    public Transform stageButtonRoot;
    public Transform chapterPanelRoot;
    public Transform indicatorRoot;

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