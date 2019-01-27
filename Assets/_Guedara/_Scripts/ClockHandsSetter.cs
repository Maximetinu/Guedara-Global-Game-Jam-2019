using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHandsSetter : MonoBehaviour
{
    public SpriteRenderer clockHandsSpriteRenderer;
    public Sprite[] clockHandSprites;
    public float quarterWaitTime = 60f;
    
    [Space(10)]
    public bool overrideFirstAtStart = false;

    int currentSprite = 0;
    
    // Start is called before the first frame update
    IEnumerator Start()
    {
        if (overrideFirstAtStart && clockHandSprites.Length >= 1)
        {
            clockHandsSpriteRenderer.sprite = clockHandSprites[0];
            currentSprite++;
        }


        while (clockHandSprites.Length > currentSprite)
        {
            yield return new WaitForSeconds(quarterWaitTime);

            clockHandsSpriteRenderer.sprite = clockHandSprites[currentSprite];
            currentSprite++;
        }
    }
}
