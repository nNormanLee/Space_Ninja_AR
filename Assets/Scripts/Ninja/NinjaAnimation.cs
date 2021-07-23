using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaAnimation : MonoBehaviour
{
    Animator animator;
    GravityBody body;
    
    public bool isRight;
    public bool isThrowing;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        body = transform.parent.GetComponent<GravityBody>();
    }

    // Update is called once per frame
    void Update()
    {
        isThrowing = false;
        animator.SetBool("isJumping", false);
        animator.SetBool("isThrowing", false);

        //running animation
        if (Input.GetKey("d"))
        {
            animator.SetBool("isRunning", true);
            transform.localRotation = Quaternion.Euler(0, 90, 0);
            isRight = true;
        }
        else if (Input.GetKey("a"))
        {
            animator.SetBool("isRunning", true);
            transform.localRotation = Quaternion.Euler(0, 270, 0);
            isRight = false;
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        //jump anim
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetBool("isJumping", true);
            animator.SetBool("isLanded", false);
        }
        else if(body.Grounded == 0)
        {
            animator.SetBool("isJumping", false);
            animator.SetBool("isLanded", true);
        }

        //throw shuriken anim
        if (Input.GetButton("Fire1"))
        {
            animator.SetBool("isThrowing", true);
            isThrowing = true;
        }
    }

    public bool IsRight()
    {
        return isRight;
    }

    public bool IsThrowing()
    {
        
        return isThrowing;
    }

            
}
