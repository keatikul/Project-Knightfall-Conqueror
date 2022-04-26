using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizontalMove = 0f;
    public float runSpeed = 40f;
    bool jump = false;
    public Animator anim;
    public AudioSource audiojump;

    void Update()
    {
       horizontalMove = Input.GetAxisRaw("Horizontal")* runSpeed;
       if (Input.GetButtonDown("Jump"))
       {
           jump = true;
           audiojump.Play();
       }
       if (Mathf.Abs(horizontalMove)>0.05f)
       {
           anim.SetBool("Run" , true);
       } else 
       {
           anim.SetBool("Run",false);
       }
    }

    void FixedUpdate() 
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false , jump);
        jump = false;
    }
   
}
