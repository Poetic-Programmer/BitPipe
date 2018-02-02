using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovementBehaviour : MonoBehaviour {
    public Color color1 = Color.red;
    public Color color2 = Color.blue;
    public float duration = 3.0F;

    Light light;

    void Start()
    {
        light = GetComponent<Light>();
        light.intensity = 40;
    }

    void Update()
    {
        float tx = (Mathf.PingPong(Time.time, duration) / duration);
        float ty = (Mathf.PingPong(Time.time, duration) / duration);
        Vector3 vec = Vector3.Lerp(new Vector3(0, 0, 0), new Vector3(255, 255, 255), tx);
        Color col = new Color(vec.x, vec.y, vec.z);
        light.color = Color.Lerp(color1, color2, tx);
        

        var x = Mathf.Lerp(-14, 14, tx);
        var y = Mathf.Lerp(30, -30, ty);
        light.transform.position = new Vector3(
            x, y, -2);

        //cam.backgroundColor = Color.Lerp(color1, color2, t);
    }
}
