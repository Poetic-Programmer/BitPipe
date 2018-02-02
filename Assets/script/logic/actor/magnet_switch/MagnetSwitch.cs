using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetSwitch : MonoBehaviour{
    SwitchSprite sprite;
    MagnetSwitchBehaviour behaviour;
    HitTesterSwitch hitTester;
    BoxCollider2D collider2D;
    public float ScaleOffset
    {
        set { scaleOffset = value; }
    }

    float scaleOffset;
    // Use this for initialization
    void Start() {
        collider2D = (BoxCollider2D)GetComponent<BoxCollider2D>();
        collider2D.transform.localScale = new Vector3(2.75f, 2.75f, 1);
        sprite = new SwitchSprite((SpriteRenderer)GetComponent<SpriteRenderer>());
        behaviour = new MagnetSwitchBehaviour();
        hitTester = new HitTesterSwitch(collider2D.bounds);

        scaleOffset = 0.5f;
        sprite.SetToColour(SwitchPipeColour.BLUE);
	}
	
	// Update is called once per frame
	void Update () {
        behaviour.Update(hitTester);
        hitTester.Update();

        UpdateTransformations();
        UpdateColours();
        UpdateCollider();
	}

    private void UpdateTransformations()
    {
        transform.localScale = behaviour.GetScaleBasedOnCurrentAnimation * scaleOffset;
        //Debug.Log(transform.localScale);
    }
    private void UpdateColours()
    {
        sprite.SetColourBasedOnBehaviour(behaviour.GetCurrentMovementType);
    }
    private void UpdateCollider()
    {
        if (hitTester.SwitchHitState == HitTesterSwitchState.RELEASED)
        {
            collider2D.enabled = false;
        }
    }
}
