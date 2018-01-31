using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetractingSwitchBehaviour : SwitchMovementBehaviour
{
    const float timeToCompleteMovement = 0.1f;
    LinearCurve2D animationCurve;

    public RetractingSwitchBehaviour()
    {
        movementTimer = SetMovementTimer();
        movementVectors = SetMovementVectors();

        animationCurve = new LinearCurve2D(movementVectors.AnimationStartPoint, movementVectors.AnimationEndPoint);
    }

    public override void Update()
    {
        
        if (!movementTimer.MovementComplete)
        {
            //Debug.Log(movementTimer.Timer);
            Debug.Log("RETRACT TIMER: " + movementTimer.Timer);
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
        return new MovementVectors(new Vector2(1.05f, 1.05f), new Vector2(0.5f, 0.5f));
    }
}
