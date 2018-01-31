using System;
using System.Collections.Generic;
using UnityEngine;

public class MovementVectors
{
    private Vector2 animationStartPoint = new Vector2();
    private Vector2 animationEndPoint = new Vector2();
    private Vector2 currentAnimationPosition;

    public MovementVectors(Vector2 animationStartPoint, Vector2 animationEndPoint)
    {
        this.animationStartPoint = animationStartPoint;
        this.animationEndPoint = animationEndPoint;
        // initialize to (1,1) so transformations don't get scaled to 0
        this.currentAnimationPosition = animationStartPoint; 
    }

    public Vector2 AnimationStartPoint{
        get { return this.animationStartPoint; }
        set { this.animationStartPoint = value; }
    }
    public Vector2 AnimationEndPoint
    {
        get { return this.animationEndPoint; }
        set { this.animationEndPoint = value; }
    }
    public Vector2 CurrentAnimationPosition
    {
        get { return this.currentAnimationPosition; }
        set { this.currentAnimationPosition = value; }
    }
}
