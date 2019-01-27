using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuedaraWakeUp : MonoBehaviour
{

    public float secondsToWakeUp = 7;
    public float secondsToStartMoving = 10;

    public GameObject guedara;
    public GameObject armonica;

    private bool started = false;
    
    // Start is called before the first frame update
    private void Start()
    {
        guedara.SetActive(false);
        armonica.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time >= secondsToWakeUp && !started)
        {
            guedara.SetActive(true);
            armonica.SetActive(true);
        }
        
        if (Time.time >= secondsToStartMoving && !started)
        {
            guedara.GetComponent<GuedaraMovement>().enabled = true;
            started = true;
        }
        
        

    }
}
