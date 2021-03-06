﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCamera : MonoBehaviour {
    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0F;

    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
        cam.backgroundColor = Color.black;
    }

    void Update()
    {
        //float t = Mathf.PingPong(Time.time, duration) / duration;
        //cam.backgroundColor = Color.Lerp(color1, color2, t);
    }
}
