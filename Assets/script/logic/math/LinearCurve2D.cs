using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearCurve2D {
    Vector2 startPoint;
    Vector2 endPoint;

    public LinearCurve2D(Vector2 start, Vector2 end)
    {
        startPoint = new Vector2(start.x, start.y);
        endPoint = new Vector2(end.x, end.y);
    }

    public LinearCurve2D (int startX, int startY, int endX, int endY) {
        startPoint = new Vector2(startX, startY);
        endPoint = new Vector2(endX, endY);
	}
	
	// Update is called once per frame
	public Vector2 GetPointAt (float time) {
        return ((1 - time) * startPoint + time * endPoint);
	}
}
