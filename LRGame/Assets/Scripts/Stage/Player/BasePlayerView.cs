using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BasePlayerView : MonoBehaviour, IPlayerView
{
  [SerializeField] private new Rigidbody2D rigidbody;
  [SerializeField] private SpriteRenderer spriteRenderer;
  [SerializeField] private PlayerType playerType;  

  public void SetActive(bool isActive)
    =>gameObject.SetActive(isActive);

  public void SetLocalPosition(Vector3 position)
    =>transform.localPosition = position;

  public void SetRoot(Transform root)
    => transform.SetParent(root);

  public void SetWorldPosition(Vector3 worldPosition)
    => transform.position = worldPosition;

  public PlayerType GetPlayerType()
    => playerType;

  public void AddWorldPosition(Vector3 value)
    => transform.position += value;

  public void AddLocalPosition(Vector3 value)
    => transform.localPosition += value;

  public void SetLinearVelocity(Vector3 velocity)
    => rigidbody.linearVelocity = velocity;

  public void AddForce(Vector3 force, ForceMode2D forceMode = ForceMode2D.Force)
    => rigidbody.AddForce(force, forceMode);

  public Vector3 GetLinearVelocity()
    => rigidbody.linearVelocity;

  public void SetAlpha(float alpha)
  {
    var color = spriteRenderer.color;
    if (color.a != alpha)
    {
      color.a = alpha;
      spriteRenderer.color = color;
    }
  }

  public void SetColor(Color color)
  {
    if (spriteRenderer.color != color)
      spriteRenderer.color = color;
  }

  public void SetSprite(Sprite sprite)
    => spriteRenderer.sprite = sprite;
}
