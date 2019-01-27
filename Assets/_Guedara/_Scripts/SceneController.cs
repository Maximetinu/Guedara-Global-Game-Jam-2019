using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneController : MonoBehaviour
{

    public UnityEvent onSceneStart;
    public UnityEvent onSceneEnd;
    public float sceneTimeDuration = 70;

    private float sceneEndTime = 0f;
    
    // Start is called before the first frame update
    void Awake()
    {
        sceneEndTime = sceneEndTime + sceneTimeDuration;
        onSceneStart.Invoke();
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= sceneEndTime)
        {
            SceneEnd();
        }

    }

    private void SceneEnd()
    {
        onSceneEnd.Invoke();
    }
}
