using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SwitchMovementBehaviour {
    protected Vector2 currentAnimationPosition;
    protected MovementTimer movementTimer;
    protected SwitchMovementType movementType;

    protected SwitchMovementBehaviour()
    {
        currentAnimationPosition = new Vector2(); 
    }
    protected SwitchMovementBehaviour(Vector2 lockPosition)
    {
        currentAnimationPosition = lockPosition;
    }

    public SwitchMovementType MovementType
    {
        get { return movementType; }
    }
    public Vector2 CurrentAnimationVector
    {
        get { return currentAnimationPosition; }
    }
    public MovementTimer MovementTimer
    {
        get { return movementTimer; }
    }
    public void Start()
    {
        movementTimer.Start();
    }
    public abstract void Update();
    protected abstract MovementTimer SetMovementTimer();
    protected abstract SwitchMovementType SetMovementType();
}
