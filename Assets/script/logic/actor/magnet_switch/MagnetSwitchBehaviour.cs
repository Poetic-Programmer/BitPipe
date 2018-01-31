using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetSwitchBehaviour
{
    SwitchAnimationVector animationVector;
    MovementAnimation currentMovementAnimation;
    MovementAnimation clickMovementAnimation;
   
    public MagnetSwitchBehaviour()
    {
        //movementBehaviour = new IdleSwitchMovementBehaviour();
        animationVector = new SwitchAnimationVector();
        currentMovementAnimation = new MovementAnimation();
        clickMovementAnimation = new MovementAnimation();
        clickMovementAnimation.AddMovement(new IdleSwitchMovementBehaviour(new Vector2(1,1)));
        clickMovementAnimation.AddMovement(new PressedSwitchBehaviour(animationVector.PressedScalingStartPoint,
            animationVector.PressedScalingEndPoint));
        clickMovementAnimation.AddMovement(new RetractingSwitchBehaviour(animationVector.RetractingScalingStartPoint,
            animationVector.RetractingScalingEndPoint));
        clickMovementAnimation.AddMovement(new RetractedSwitchMovementBehaviour(animationVector.RetractingScalingEndPoint));
    }

    public Vector3 GetScaleBasedOnCurrentAnimation{
        get { return clickMovementAnimation.GetCurrentMovementBehaviour.CurrentAnimationVector; }
    }
    public SwitchMovementType GetCurrentMovementType
    {
        get { return clickMovementAnimation.GetCurrentMovementBehaviour.MovementType; }
    }

    // Update is called once per frame
    public void Update(HitTesterSwitch hitTester)
    {
        //Debug.Log(clickMovementAnimation.GetCurrentMovementBehaviour.MovementType);
        if (hitTester.SwitchHitState == HitTesterSwitchState.PRESSED)
        {
            clickMovementAnimation.Start();
        }
        clickMovementAnimation.Update();
    }
}
