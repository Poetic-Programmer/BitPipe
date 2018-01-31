using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour {
    HitTesterSwitch hitTester;
    SwitchSprite spriteHandler;
    BoxCollider2D collider2D;
    SwitchMovementBehaviour movementBehaviour;
    MovementAnimation clickMovementAnimation;

    public Vector2 Scale { get; set; }

	// Use this for initialization
	void Start () {
        spriteHandler = new SwitchSprite((SpriteRenderer)GetComponent<SpriteRenderer>());
        collider2D = (BoxCollider2D)GetComponent<BoxCollider2D>();
        hitTester = new HitTesterSwitch(collider2D.bounds);
        movementBehaviour = new IdleSwitchBehaviour();
        clickMovementAnimation = new MovementAnimation();
        clickMovementAnimation.AddMovement(new PressedSwitchBehaviour());
        clickMovementAnimation.AddMovement(new RetractingSwitchBehaviour());
        spriteHandler.SetToColour(SwitchPipeColour.PURPLE);
        Scale = new Vector2();
	}
	
	// Update is called once per frame
	void Update () {
        clickMovementAnimation.Update();
        Scale = clickMovementAnimation.GetCurrentMovementBehaviour.MovementVectors.CurrentAnimationPosition;
        Debug.Log(Scale);
		if (hitTester.SwitchHitState == HitTesterSwitchState.PRESSED)
        {
            spriteHandler.SetToColour(SwitchPipeColour.YELLOW);
            clickMovementAnimation.Start();    
        }

        if(clickMovementAnimation.Started)
        {
            if (clickMovementAnimation.Finished)
            {
                Debug.Log("RED");
                spriteHandler.SetToColour(SwitchPipeColour.RED);
            }
        }
        transform.localScale = new Vector3(Scale.x, Scale.y, 0);
        hitTester.Update();
	}
}
