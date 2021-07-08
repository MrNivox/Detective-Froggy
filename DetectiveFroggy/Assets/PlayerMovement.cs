using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public Charactercontroller2d controller;
    float horizontalMove = 0f;
    public float RunSpeed = 40f;
    bool jump = false;
    bool crouch = false;
    public Joystick joystick;

    // Update is called once per frame
    void Update()
    {
     if (joystick.Horizontal >+ .2f )
     {
      horizontalMove = RunSpeed;
     }else if (joystick.Horizontal <= -.2f)
     {
        horizontalMove = -RunSpeed;
     }else
     {
           horizontalMove = 0f;
     }

    if (joystick.Vertical >= .5f)
    {
        jump = true;
    }

    if (joystick.Vertical <= -.5f)
    {
      crouch = true;
    }
    else 
    {
      crouch = false;
    }

    }
    void FixedUpdate()
    {
      controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
      jump = false;



    }

}
