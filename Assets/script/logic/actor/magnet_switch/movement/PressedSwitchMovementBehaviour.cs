using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedSwitchBehaviour : SwitchMovementBehaviour
{
    const float timeToCompleteMovement = 0.05f;
    LinearCurve2D animationCurve;

    public PressedSwitchBehaviour(Vector2 startPoint, Vector2 endPoint) : base()
    {
        movementTimer = SetMovementTimer();
        animationCurve = new LinearCurve2D(startPoint, endPoint);
    }

    public override void Update()
    {
        if(!movementTimer.MovementComplete)
        {
            currentAnimationPosition = animationCurve.GetPointAt(
                movementTimer.Timer);
        }
        movementTimer.Update();
    }

    protected override MovementTimer SetMovementTimer()
    {
        return new MovementTimer(timeToCompleteMovement);
    }

    protected override SwitchMovementType SetMovementType()
    {
        return SwitchMovementType.PULLING_BACK;
    }
}
