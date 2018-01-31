using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetractingSwitchBehaviour : SwitchMovementBehaviour
{
    const float timeToCompleteMovement = 0.2f;
    LinearCurve2D animationCurve;

    public RetractingSwitchBehaviour(Vector2 startPoint, Vector2 endPoint) : base()
    {
        movementTimer = SetMovementTimer();
        movementType = SetMovementType();
     
        animationCurve = new LinearCurve2D(startPoint, endPoint);
    }

    public override void Update()
    {
        movementTimer.Update();
        if (!movementTimer.MovementComplete)
        {
            currentAnimationPosition = animationCurve.GetPointAt(
                movementTimer.Timer);
        }       
    }

    protected override MovementTimer SetMovementTimer()
    {
        return new MovementTimer(timeToCompleteMovement);
    }

    protected override SwitchMovementType SetMovementType()
    {
        return SwitchMovementType.RETRACTING;
    }
}
