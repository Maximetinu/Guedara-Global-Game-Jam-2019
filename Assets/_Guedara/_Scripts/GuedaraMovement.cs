using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Animator))]
public class GuedaraMovement : MonoBehaviour
{
    public float speed;

    SpriteRenderer mySprite;
    Animator myAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        myAnim.SetBool("moving", Mathf.Abs(horizontalInput) > 0f);
        
        transform.position += horizontalInput * Vector3.right * speed * Time.deltaTime;

        // IF Going right AND looking left THEN look right
        if (horizontalInput > 0f && mySprite.flipX == true)
        {
            mySprite.flipX = false; // Look left
        }
        else if (horizontalInput < 0f && mySprite.flipX == false)
        {
            mySprite.flipX = true;
        }
    }
}
