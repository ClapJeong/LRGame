using System;
using TMPro;
using UniRx;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UILobbyBeginButtonView : MonoBehaviour, IButtonController, ITMPController
{
  [SerializeField] private Button button;
  [SerializeField] private TextMeshProUGUI tmp;

  private readonly UnityEvent onClick = new ();
  private IDisposable buttonDispose;

  private void Awake()
  {
    buttonDispose = button
      .OnClickAsObservable()
      .Subscribe(_ => onClick?.Invoke());
  }

  public void AppendText(string text)
    => tmp.text += text;

  public void SetText(string text)
    => tmp.text = text;

  public void SetInteractable(bool interactable)
    =>button.interactable = interactable;

  public void SubscribeOnClick(UnityAction onClick)
  {
    this.onClick.RemoveListener(onClick);
    this.onClick.AddListener(onClick);
  }

  public void UnsubscribeOnClick(UnityAction onClick)
  {
    this.onClick.RemoveListener(onClick);
  }

  public void Dispose()
  {
    buttonDispose.Dispose();
  }

  public void DisposeOnClick()
  {
    buttonDispose.Dispose();
  }
}
