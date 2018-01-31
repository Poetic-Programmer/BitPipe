using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchSprite {
    SwitchSpriteLoader spriteLoader;
    SpriteRenderer spriteRenderer;
    SwitchPipeColour colour;

	public SwitchSprite(SpriteRenderer renderer) {
        spriteLoader = new SwitchSpriteLoader();
        spriteRenderer = renderer;
        colour = SwitchPipeColour.WHITE;
        spriteRenderer.sprite = spriteLoader.GetColour(colour);
	}
	
	void Update () {
        
	}

    public void SetToColour(SwitchPipeColour colour)
    {
        spriteRenderer.sprite = spriteLoader.GetColour(colour);
    }
}
