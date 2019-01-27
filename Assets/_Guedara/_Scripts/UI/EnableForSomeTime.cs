using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableForSomeTime : MonoBehaviour
{
    void Disable()
    {
        gameObject.SetActive(false);
    }

    public void EnableForTime(float time)
    {
        gameObject.SetActive(true);
        Invoke("Disable", time);
    }
}
