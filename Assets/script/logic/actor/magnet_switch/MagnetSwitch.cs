using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetSwitch : MonoBehaviour {
    SwitchSprite sprite;
    MagnetSwitchBehaviour behaviour;
    HitTesterSwitch hitTester;

	// Use this for initialization
	void Start () {
        BoxCollider2D collider2D = (BoxCollider2D)GetComponent<BoxCollider2D>();
        SpriteRenderer renderer = (SpriteRenderer)GetComponent<SpriteRenderer>();

        sprite = new SwitchSprite(renderer);
        behaviour = new MagnetSwitchBehaviour();
        hitTester = new HitTesterSwitch(collider2D.bounds);

        sprite.SetToColour(SwitchPipeColour.BLUE);
	}
	
	// Update is called once per frame
	void Update () {
        behaviour.Update(hitTester);
        hitTester.Update();

        UpdateTransformations();
        UpdateColours();
	}

    private void UpdateTransformations()
    {
        transform.localScale = behaviour.GetScaleBasedOnCurrentAnimation;
        Debug.Log(transform.localScale);
    }
    private void UpdateColours()
    {
        sprite.SetColourBasedOnBehaviour(behaviour.GetCurrentMovementType);
    }
}
