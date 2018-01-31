using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SwitchMovementBehaviour {
    protected MovementVectors movementVectors;
    protected MovementTimer movementTimer;

    public MovementVectors MovementVectors
    {
        get { return movementVectors; }
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
    protected abstract MovementVectors SetMovementVectors();
    protected abstract MovementTimer SetMovementTimer();
}
