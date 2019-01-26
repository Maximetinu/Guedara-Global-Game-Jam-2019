using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHandsSetter : MonoBehaviour
{
    public SpriteRenderer minutesSpriteRenderer;
    public Sprite[] minutesSprites;
    public float quarterHourWaitTime = 60f;
    
    [Space(10)]
    public bool overrideFirstAtStart = false;

    int currentSprite = 0;
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        if (overrideFirstAtStart && minutesSprites.Length >= 1)
        {
            minutesSpriteRenderer.sprite = minutesSprites[0];
            currentSprite++;
        }


        while (minutesSprites.Length > currentSprite)
        {
            yield return new WaitForSeconds(quarterHourWaitTime);

            minutesSpriteRenderer.sprite = minutesSprites[currentSprite];
            currentSprite++;
        }
    }
}
