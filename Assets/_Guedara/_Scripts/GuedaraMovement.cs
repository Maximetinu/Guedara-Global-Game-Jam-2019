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

    private bool canMove = true;
    
    // Start is called before the first frame update
    void Start()
    {
        mySprite = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float nextStep = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        
        // IF Going right AND looking left THEN look right
        if (nextStep > 0f && mySprite.flipX == true)
        {
            mySprite.flipX = false; // Look left
        }
        else if (nextStep < 0f && mySprite.flipX == false)
        {
            mySprite.flipX = true;
        }

        if (canMove && Mathf.Abs(transform.position.x + nextStep) < 8f)
        {
            myAnim.SetBool("moving", Mathf.Abs(nextStep) > 0f);
            transform.position += nextStep * Vector3.right;
        }
        

    }
    
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Armonica"))
        {
            myAnim.SetTrigger("coger_armonica");
            Destroy(other.gameObject);
            canMove = false;
            playArmonica();
        }

    }

    private void playArmonica()
    {
        GetComponent<AudioSource>().Play();
    }
}
