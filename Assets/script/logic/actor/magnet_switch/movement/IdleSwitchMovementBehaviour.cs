using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleSwitchMovementBehaviour : SwitchMovementBehaviour
{
    public IdleSwitchMovementBehaviour(Vector2 lockPosition) : base(lockPosition)
    {
        movementTimer = SetMovementTimer();
        movementType = SetMovementType();
    }
    public override void Update()
    {
        movementTimer.Update();
    }

    protected override MovementTimer SetMovementTimer()
    {
        return new MovementTimer(0);
    }

    protected override SwitchMovementType SetMovementType()
    {
        return SwitchMovementType.NONE;
    }
}
