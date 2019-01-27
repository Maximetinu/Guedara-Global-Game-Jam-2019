using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShadowAnimationEvents : MonoBehaviour
{
    public UnityEvent onAnimationEnd;
    
    public void OnAnimationEnd()
    {
        onAnimationEnd.Invoke();
    }
}
