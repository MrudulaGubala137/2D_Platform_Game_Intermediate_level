using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float PlayerSpeed;
    public Rigidbody2D rb;
    SpriteRenderer render;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        render=GetComponent<SpriteRenderer>();
        animator=GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal") * PlayerSpeed;

        rb.velocity = new Vector3(inputX, rb.velocity.y);
        if (inputX < 0)
        {
            render.flipX = true;
        }
        else
        {
            render.flipX = false;
            animator.SetBool("IsWalk", inputX != 0);
        }
    }
}
