using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Tables;
using UnityEngine.Localization.Components;
using Cysharp.Threading.Tasks;



#if UNITY_EDITOR
using UnityEditor.Localization;
#endif

[ExecuteInEditMode]
[RequireComponent(typeof(TextMeshProUGUI))]
[RequireComponent(typeof(LocalizeStringEvent))]
public class LocalizeFontEvent : MonoBehaviour
{  
  [SerializeField] private LocalizedTmpFont fontReference = new();
  [Space(5)]
  [SerializeField] private List<TextMeshProUGUI> textmeshPros = new();
  private LocalizeStringEvent localizeStringEvent;

#if UNITY_EDITOR
  private bool TryAssignExistingFontTable(out LocalizedTmpFont assetReference)
  {
    assetReference = new LocalizedTmpFont();

    // ✅ 1. 모든 Asset Table Collection 가져오기
    var collections = LocalizationEditorSettings.GetAssetTableCollections();

    foreach (var collection in collections)
    {
      foreach (var table in collection.Tables)
      {
        var assetTable = table.asset as AssetTable;
        if (assetTable == null) continue;

        // 테이블의 첫 엔트리를 확인하여 타입 판정
        foreach (var entry in assetTable.SharedData.Entries)
        {
          var handle = assetTable.GetAssetAsync<TMP_FontAsset>(entry.Key);
          var asset = handle.Result;

          if (asset is TMP_FontAsset) // ✅ 여기서 타입 판정
          {
            assetReference.TableReference = collection.TableCollectionName;
            assetReference.TableEntryReference = entry.Key;
            return true;
          }
        }
      }
    }

    return true;
  }

  private void OnEnable()
  {
    if (localizeStringEvent == null)
      localizeStringEvent = GetComponent<LocalizeStringEvent>();

    if (fontReference.IsEmpty && TryAssignExistingFontTable(out var assetReference))
      fontReference = assetReference;

    if (textmeshPros.Count == 0)
      CacheAllTMP();

    RefreshFont();
    Register();
  }
#endif

  private void OnDisable()
    => Unregister();

  private void OnDestroy()
    => Unregister();


  private async void RefreshFont()
  {
    try
    {
      var handle = await fontReference.LoadAssetAsync().ToUniTask();
      var currentTMP = handle;

      foreach (var tmp in textmeshPros)
        tmp.font = currentTMP;
    }
    catch (System.Exception)
    {

    }
  }


  private void Register()
  {    
    LocalizationSettings.SelectedLocaleChanged += OnLocaleChanged;
    fontReference.AssetChanged += OnAssetChanged;
    localizeStringEvent.OnUpdateString.AddListener(OnUpdateString);
  }

  private void Unregister()
  {
    LocalizationSettings.SelectedLocaleChanged -= OnLocaleChanged;
    fontReference.AssetChanged -= OnAssetChanged;
    localizeStringEvent.OnUpdateString.RemoveListener(OnUpdateString);
  }

  private void OnUpdateString(string text)
  {
    RefreshFont();
  }

  private void OnLocaleChanged(Locale locale)
  {
    RefreshFont();
  }

  private void OnAssetChanged(TMP_FontAsset fontAsset)
  {
    RefreshFont();
  }

  [ContextMenu("Cache All TMP")]
  private void CacheAllTMP()
  {
    textmeshPros = GetComponentsInChildren<TextMeshProUGUI>().ToList();
  }
}
