using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Components;

public class UIStageRestartView : MonoBehaviour, IRectController, ILocalizeStringController
{
  [SerializeField] private RectTransform RectTransform;
  [SerializeField] private LocalizeStringEvent stringEvent;

  public void SetActive(bool isActive)
    => gameObject.SetActive(isActive);

  public void SetArgument(List<object> arguments)
  {
    stringEvent.StringReference.Arguments = arguments;
    stringEvent.RefreshString();
  }

  public void SetEntry(string key)
    => stringEvent.SetEntry(key);

  public void SetEuler(Vector3 euler)
    => RectTransform.eulerAngles = euler;

  public void SetLocalPosition(Vector3 position)
    => RectTransform.localPosition = position;

  public void SetRoot(Transform root)
    => RectTransform.SetParent(root);

  public void SetRotation(Quaternion rotation)
    => RectTransform.rotation = rotation;

  public void SetScale(Vector3 scale)
    => RectTransform.localScale = scale;

  public void SetWorldPosition(Vector3 worldPosition)
    => RectTransform.localPosition = worldPosition;
}
