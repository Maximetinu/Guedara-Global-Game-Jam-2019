using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneController : MonoBehaviour
{

    public UnityEvent onSceneStart;
    public UnityEvent onSceneEnd;
    public float sceneTimeDuration = 70f;
    public float timeToTrain = 60f;
    public GameObject train;

    private float sceneEndTime = 0f;
    private float trainTime = 0f;
    
    // Start is called before the first frame update
    void Awake()
    {
        sceneEndTime = Time.time + sceneTimeDuration;
        trainTime = Time.time + timeToTrain;
        onSceneStart.Invoke();
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time >= sceneEndTime)
        {
            SceneEnd();
        }

        if (Time.time >= trainTime)
        {
            GoTrain();
        }

    }

    private void SceneEnd()
    {
        onSceneEnd.Invoke();
    }

    public void GoTrain()
    {
        train.GetComponent<Animator>().SetTrigger("go");
        trainTime = Time.time + timeToTrain;
    }
}
