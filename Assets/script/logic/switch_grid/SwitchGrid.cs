using UnityEngine;

public class SwitchGrid : MonoBehaviour{
    private const int NUMBER_OF_SWITCHES_IN_ROW = 5;
    //MagnetSwitch[] gridRow;
    // Use this for initialization
    public Transform magnetSwitch;

    void Start()
    {
        SetEvenRows();
        SetOddRows();
    }

    private void SetEvenRows()
    {
        int horizontalGapBetweenSwitches = 7;
        var verticalGapBetweenSwitches = 6.062f;

        Vector2 startPosition = new Vector2(-14.5f, 25);

        for (int y = 0; y < 8; y++)
        {
            if (y % 2 == 0)
            {
                for (int x = 0; x < 6; x++)
                {
                    Instantiate(magnetSwitch, new Vector3(-3.5f + startPosition.x + x * horizontalGapBetweenSwitches,
                        startPosition.y - y * verticalGapBetweenSwitches, 0), Quaternion.identity);
                }
            }

        }
    }
    private void SetOddRows()
    {
        int horizontalGapBetweenSwitches = 7;
        var verticalGapBetweenSwitches = 6.062f;

        Vector2 startPosition = new Vector2(-14.5f, 25);
        for (int y = 0; y < 8; y++)
        {
            if (y % 2 == 1)
            {
                for (int x = 0; x < 5; x++)
                {
                    Instantiate(magnetSwitch, new Vector3(startPosition.x + x * horizontalGapBetweenSwitches,
                        startPosition.y - y * verticalGapBetweenSwitches, 0), Quaternion.identity);
                }
            }

        }
    }
    private void Update()
    {
        
        transform.position = new Vector3(10, 10, 0);
    }
}
