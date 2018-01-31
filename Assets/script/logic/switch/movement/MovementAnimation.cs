using System;
using System.Collections.Generic;
using UnityEngine;

public class MovementAnimation
{
    private List<SwitchMovementBehaviour> movement;
    private bool startMovement;
    private int currentMovement;
    private bool finished;

    public bool Finished
    {
        get { return finished; }
    }   
    public bool Started
    {
        get { return startMovement; }
    }

    public MovementAnimation()
    {
        movement = new List<SwitchMovementBehaviour>();
        startMovement = false;
        currentMovement = 0;
        finished = false;
    }

    public SwitchMovementBehaviour GetCurrentMovementBehaviour
    {
        get { return movement[currentMovement]; }
    }

    public void AddMovement(SwitchMovementBehaviour movementBehaviour)
    {
        Debug.Log("Added: " + movement.Count);
        movement.Add(movementBehaviour);
    }

    public void Start()
    {
        startMovement = true;
        movement[currentMovement].Start();
    }

    public void Update()
    {
        //Debug.Log((currentMovement + 1) + ", " + movement.Count);
        if (startMovement)
        {
            movement[currentMovement].Update();
            if (CanMoveToNextMovement())
            {
                currentMovement++;
                movement[currentMovement].Start();
            }
        }
        finished = IsAnimationComplete();
    }

    private bool IsAnimationComplete()
    {
        if (currentMovement == movement.Count - 1)
        {
            return movement[currentMovement].MovementTimer.MovementComplete;
        }
        return false;
    }
    private bool CanMoveToNextMovement()
    {
        if (movement[currentMovement].MovementTimer.MovementComplete)
        {
            if (currentMovement < movement.Count - 1)
            {
                return true;
            }
        }
        return false;
    }
}
