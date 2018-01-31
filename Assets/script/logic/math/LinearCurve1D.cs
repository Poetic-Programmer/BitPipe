using System;
using System.Collections.Generic;
using UnityEngine;

class LinearCurve1D
{
    float startX;
    float endX;

    public LinearCurve1D(float startX, float endX)
    {
        this.startX = startX;
        this.endX = endX;
    }

    public float GetPointAt(float time)
    {
        return ((1 - time) * startX + time * endX);
    }
}
