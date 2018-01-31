using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitTesterSwitch {
    Bounds switchBounds;

    public HitTesterSwitchState SwitchHitState {
        get; set;
    }

    // Use this for initialization
    public HitTesterSwitch(Bounds spriteBounds) {
        switchBounds = spriteBounds;
        SwitchHitState = HitTesterSwitchState.IDLE;
	}
	
	// Update is called once per frame
	public void Update () {
        var pos = Input.mousePosition; 
        pos = Camera.main.ScreenToWorldPoint(pos);
        pos.z = 0;
  
        if (switchBounds.Contains(pos))
        {
            switch (SwitchHitState)
            {
                case HitTesterSwitchState.IDLE:
                    if (Input.GetMouseButtonDown(0))
                        SwitchState(HitTesterSwitchState.PRESSED);
                    break;
                case HitTesterSwitchState.PRESSED:
                    
                    break;
                case HitTesterSwitchState.RELEASED:
                    SwitchState(HitTesterSwitchState.IDLE);
                    break;
            }
        }
        else
        {
            SwitchState(HitTesterSwitchState.IDLE);
        }
	}

    void SwitchState(HitTesterSwitchState toState)
    {
        SwitchHitState = toState;
    }

    public void TestBounds()
    {

    }
}
