using Cysharp.Threading.Tasks;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public static StageManager instance;

  [SerializeField] private PlayerSetupService playerSetupService;

  private void Awake()
  {
    instance = this;

    playerSetupService.SetupAsync().Forget();
  }
}
