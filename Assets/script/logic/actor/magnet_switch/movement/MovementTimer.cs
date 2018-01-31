using System;
using System.Collections.Generic;
using UnityEngine;

public class MovementTimer
{
    private float timer;
    private float timeToCompleteInSeconds;
    private float speedModifier;
    private bool movementComplete;
    private bool movementLocked;
    private bool movementStart;

    public bool MovementComplete
    {
        get { return movementComplete; }
    }
    public bool MovementLocked
    {
        get { return movementLocked; }
    }
    public float Timer
    {
        get { return timer; }
    }

    public MovementTimer(float timeToCompleteInSeconds)
    {
        this.timeToCompleteInSeconds = timeToCompleteInSeconds;

        timer = 0;
        speedModifier = 1;
        movementComplete = false;
        movementStart = false;
        movementLocked = false;
    }

    public void Start()
    {
        Reset();
        movementLocked = true;
        movementStart = true;
    }
    public void Update()
    {  
        if (!movementComplete && movementStart)
        {   
            timer += (Time.deltaTime / timeToCompleteInSeconds) * speedModifier;

            if (timer >= 1)
            {
                timer = 1;
                movementLocked = false;
                movementComplete = true;
            }
        }
    }

    public void Reset()
    {
        movementComplete = false;
        timer = 0;
    }
}
