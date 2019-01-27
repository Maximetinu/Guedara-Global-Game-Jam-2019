using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AutumnScene : MonoBehaviour
{
    public UnityEvent onFadeHalf;
    public UnityEvent onFadeEnd;

    public void OnFadeHalf()
    {
        onFadeHalf.Invoke();
    }

    public void OnFadeEnd()
    {
        onFadeEnd.Invoke();
    }
}
