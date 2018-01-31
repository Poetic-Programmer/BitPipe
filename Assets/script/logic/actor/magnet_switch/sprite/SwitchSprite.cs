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

    public void SetToColour(SwitchPipeColour colour)
    {
        spriteRenderer.sprite = spriteLoader.GetColour(colour);
    }

    public void SetColourBasedOnBehaviour(SwitchMovementType type)
    {
        switch (type)
        {
            case SwitchMovementType.NONE:
                spriteRenderer.sprite = spriteLoader.GetColour(SwitchPipeColour.PURPLE);
                break;
            case SwitchMovementType.PULLING_BACK:
                spriteRenderer.sprite = spriteLoader.GetColour(SwitchPipeColour.YELLOW);
                break;
            case SwitchMovementType.RETRACTING:
                spriteRenderer.sprite = spriteLoader.GetColour(SwitchPipeColour.YELLOW);
                break;
            case SwitchMovementType.RETRACTED:
                spriteRenderer.sprite = spriteLoader.GetColour(SwitchPipeColour.RED);
                break;
        }
    }
}
