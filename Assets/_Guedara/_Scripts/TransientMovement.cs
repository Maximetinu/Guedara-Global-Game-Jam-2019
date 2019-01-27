using System.Collections;
using UnityEngine;

public class TransientMovement : MonoBehaviour
{
    [Range(0.2f, 4f)]
    public float speed = 1;
    public float initialWait;
    public float timeForStop = 4f;
    public float stopTime = 4f;
    public bool flipWhenStop = false;
    public bool goBack = false;

    [Space(10)] [Range(0.2f, 4f)]
    public float animSpeed = 1f;
    

    Animator myAnim;
    SpriteRenderer mySprite;
    bool walking = false;
    
    IEnumerator Start()
    {
        myAnim = GetComponent<Animator>();
        mySprite = GetComponent<SpriteRenderer>();
        
        myAnim.speed = animSpeed;

        if (mySprite.flipX == true)
        {
            speed = -speed;
        }
        
        yield return new WaitForSeconds(initialWait);

        walking = true;
        myAnim.SetBool("moving", true);

        yield return new WaitForSeconds(timeForStop);

        walking = false;
        myAnim.SetBool("moving", false);
        
        if (flipWhenStop)
        {
            mySprite.flipX = !mySprite.flipX;
        }

        yield return new WaitForSeconds(stopTime);

        walking = true;
        myAnim.SetBool("moving", true);
        
        if (flipWhenStop)
        {
            mySprite.flipX = !mySprite.flipX;
        }

        if (goBack)
        {
            mySprite.flipX = !mySprite.flipX;
            speed = -speed;
        }
    }

    void Update()
    {
        if (walking)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    void OnDrawGizmosSelected()
    {
        if (Application.isPlaying == false)
        {
            Color gizmoColor = Color.white;
            gizmoColor.a = 0.5f;
            Gizmos.color = gizmoColor;

            Vector3 lookingTo = GetComponent<SpriteRenderer>().flipX == true ? Vector3.left : Vector3.right;
        
            Gizmos.DrawSphere(transform.position + lookingTo * speed * timeForStop + Vector3.up, 0.25f);
        }
    }
}
