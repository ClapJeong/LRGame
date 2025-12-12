using UnityEngine;

namespace LR.Stage.Player
{
  public class BasePlayerView : MonoBehaviour, IPlayerView
  {
    [SerializeField] private new Rigidbody2D rigidbody;
    [SerializeField] private PlayerType playerType;

    [Header("[ View ]")]
    [SerializeField] private BaseGameObjectView gameObjectView;
    [SerializeField] private BasePositionView positionView;
    [SerializeField] private BaseSpriteRendererView spriteRendererView;

    #region IPlayerView
    public PlayerType GetPlayerType()
      => playerType;
    #endregion

    #region IGameObjectView
    public void SetActive(bool isActive)
      => gameObjectView.SetActive(isActive);

    public void SetRoot(Transform root)
      => gameObjectView.SetRoot(root);

    public void DestroyGameObject()
      => gameObjectView.DestroyGameObject();
    #endregion

    #region IPositionView
    public void SetLocalPosition(Vector3 position)
      => positionView.SetLocalPosition(position);

    public void SetWorldPosition(Vector3 worldPosition)
      => positionView.SetWorldPosition(worldPosition);

    public void AddWorldPosition(Vector3 value)
      => positionView.AddWorldPosition(value);

    public void AddLocalPosition(Vector3 value)
      => positionView.AddLocalPosition(value);

    public Vector3 GetWorldPosition()
      => positionView.GetWorldPosition();

    public Vector3 GetLocalPosition()
      => positionView.GetLocalPosition();
    #endregion

    #region IRigidbodyController
    public void SetLinearVelocity(Vector3 velocity)
      => rigidbody.linearVelocity = velocity;

    public void AddForce(Vector3 force, ForceMode2D forceMode = ForceMode2D.Force)
      => rigidbody.AddForce(force, forceMode);

    public Vector3 GetLinearVelocity()
      => rigidbody.linearVelocity;
    #endregion

    #region ISpriteRendererView
    public void SetAlpha(float alpha)
      => spriteRendererView.SetAlpha(alpha);

    public void SetColor(Color color)
      => spriteRendererView.SetColor(color);

    public void SetSprite(Sprite sprite)
      => spriteRendererView.SetSprite(sprite);
    #endregion
  }
}