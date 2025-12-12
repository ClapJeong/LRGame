using UnityEngine;

namespace LR.Stage.Player
{
  public class BasePlayerMoveController : IPlayerMoveController
  {
    private readonly PlayerModel model;
    private readonly IRigidbodyController rigidbodyController;
    private readonly IPlayerInputActionController inputActionController;

    private Vector3 inputDirection;

    public BasePlayerMoveController(IRigidbodyController rigidbodyController, IPlayerInputActionController inputActionController, PlayerModel model)
    {
      this.rigidbodyController = rigidbodyController;
      this.inputActionController = inputActionController;
      this.model = model;

      inputActionController.SubscribeOnPerformed(OnPerformed);
      inputActionController.SubscribeOnCanceled(OnCanceled);
    }

    public void SetLinearVelocity(Vector3 velocity)
      => rigidbodyController.SetLinearVelocity(velocity);

    public void ApplyMoveAcceleration()
    {
      Vector3 currentVel = rigidbodyController.GetLinearVelocity();
      Vector3 desiredVel = inputDirection.normalized * model.so.Movement.MaxSpeed;

      currentVel = Vector3.MoveTowards(
            currentVel,
            desiredVel,
            model.so.Movement.Acceleration * Time.fixedDeltaTime);

      rigidbodyController.SetLinearVelocity(currentVel);
    }

    public void ApplyMoveDeceleration()
    {
      Vector3 currentVel = rigidbodyController.GetLinearVelocity();

      currentVel = Vector3.MoveTowards(
      currentVel,
      Vector3.zero,
      model.so.Movement.Decceleration * Time.fixedDeltaTime);

      rigidbodyController.SetLinearVelocity(currentVel);
    }

    public void Dispose()
    {
      inputActionController?.UnsubscribePerfoemd(OnPerformed);
      inputActionController?.UnsubscribeCanceled(OnCanceled);
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