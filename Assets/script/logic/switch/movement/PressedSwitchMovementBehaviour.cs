using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressedSwitchBehaviour : SwitchMovementBehaviour
{
    const float timeToCompleteMovement = 0.01f;
    LinearCurve2D animationCurve;

    public PressedSwitchBehaviour()
    {
        movementVectors = SetMovementVectors();
        movementTimer = SetMovementTimer();
        animationCurve = new LinearCurve2D(movementVectors.AnimationStartPoint,
            movementVectors.AnimationEndPoint);
    }

    public override void Update()
    {
        if(!movementTimer.MovementComplete)
        {
            //Debug.Log(movementVectors.CurrentAnimationPosition);
            Debug.Log("PRESSED TIMER: " + movementTimer.Timer);
            movementVectors.CurrentAnimationPosition = animationCurve.GetPointAt(
                movementTimer.Timer);
        }
        movementTimer.Update();
    }

    protected override MovementTimer SetMovementTimer()
    {
        return new MovementTimer(timeToCompleteMovement);
    }

    protected override MovementVectors SetMovementVectors()
    {
        return new MovementVectors(new Vector2(1, 1), new Vector2(1.05f, 1.05f));
    }
}
