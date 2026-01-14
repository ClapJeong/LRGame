using UnityEngine;

namespace LR.Stage.Player
{
  public class BasePlayerMoveController : IPlayerMoveController
  {
    private readonly PlayerModel model;
    private readonly Rigidbody2D rigidbody2D;
    private readonly IPlayerInputActionController inputActionController;

    private Vector3 inputDirection;

    public BasePlayerMoveController(Rigidbody2D rigidbody2D, IPlayerInputActionController inputActionController, PlayerModel model)
    {
      this.rigidbody2D = rigidbody2D;
      this.inputActionController = inputActionController;
      this.model = model;

      inputActionController.SubscribeOnPerformed(OnPerformed);
      inputActionController.SubscribeOnCanceled(OnCanceled);
    }

    public void SetLinearVelocity(Vector3 velocity)
      => rigidbody2D.linearVelocity = velocity;

    public void ApplyMoveAcceleration()
    {
      Vector3 currentVel = rigidbody2D.linearVelocity;
      Vector3 desiredVel = inputDirection.normalized * model.so.Movement.MaxSpeed;

      currentVel = Vector3.MoveTowards(
            currentVel,
            desiredVel,
            model.so.Movement.Acceleration * Time.fixedDeltaTime);

      SetLinearVelocity(currentVel);
    }

    public void ApplyMoveDeceleration()
    {
      Vector3 currentVel = rigidbody2D.linearVelocity;

      currentVel = Vector3.MoveTowards(
      currentVel,
      Vector3.zero,
      model.so.Movement.Decceleration * Time.fixedDeltaTime);

      SetLinearVelocity(currentVel);
    }
    public Vector2 GetCurrentDirection()
      => inputDirection;

    public void Dispose()
    {
      inputActionController.UnsubscribePerfoemd(OnPerformed);
      inputActionController.UnsubscribeCanceled(OnCanceled);
    }

    private void OnPerformed(Direction direction)
    {
      var velocity = model.ParseDirection(direction);
      inputDirection += velocity;
    }

    private void OnCanceled(Direction direction)
    {
      var velocity = model.ParseDirection(direction);
      inputDirection -= velocity;
    }    
  }
}