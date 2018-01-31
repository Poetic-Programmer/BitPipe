using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleSwitchBehaviour : SwitchMovementBehaviour
{
    public IdleSwitchBehaviour()
    {
        movementVectors = SetMovementVectors();
        movementTimer = SetMovementTimer();
    }
    public override void Update()
    {
        
    }

    protected override MovementTimer SetMovementTimer()
    {
        return new MovementTimer(0);
    }

    protected override MovementVectors SetMovementVectors()
    {
        return new MovementVectors(new Vector2(), new Vector2());
    }
}
