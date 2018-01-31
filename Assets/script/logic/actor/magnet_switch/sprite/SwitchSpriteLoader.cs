using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class SwitchSpriteLoader
{
    string pathToSprites = "";
    string[] spriteImage = {
        "SwitchesB/switch_no_light",
        "SwitchesB/switch_red_light",
        "SwitchesB/switch_blue_light",
        "SwitchesB/switch_green_light",
        "SwitchesB/switch_yellow_light",
        "SwitchesB/switch_purple_light",
        "SwitchesB/switch_orange_light"};
    Sprite[] switchSprite;

    public SwitchSpriteLoader()
    {
        var numberOfSprites = spriteImage.Length;
        switchSprite = new Sprite[numberOfSprites];
        LoadSprites();
    }

    void LoadSprites()
    {
        var offset = 0;
        foreach (string s in spriteImage)
        {
            switchSprite[offset++] = Resources.Load<Sprite>(pathToSprites + s);
        }
    }

    public Sprite GetColour(SwitchPipeColour colour)
    {
        return switchSprite[(int)colour];
    }
}
