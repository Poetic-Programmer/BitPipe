using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAnimationVector {
    private Vector2 pressedScalingStartPoint;
    private Vector2 pressedScalingEndPoint;
    private Vector2 retractingScalingStartPoint;
    private Vector2 retractingScalingEndPoint;

    public SwitchAnimationVector()
    {
        pressedScalingStartPoint = new Vector2(1, 1);
        pressedScalingEndPoint = new Vector2(1.2f, 1.2f);
        retractingScalingStartPoint = pressedScalingEndPoint;
        retractingScalingEndPoint = new Vector2(0.75f, 0.75f);
    }

    public Vector2 PressedScalingStartPoint
    {
        get { return pressedScalingStartPoint; }
    }
    public Vector2 PressedScalingEndPoint
    {
        get { return pressedScalingEndPoint; }
    }
    public Vector2 RetractingScalingStartPoint
    {
        get { return retractingScalingStartPoint; }
    }
    public Vector2 RetractingScalingEndPoint
    {
        get { return retractingScalingEndPoint; }
    }

}
