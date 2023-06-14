using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public CharacterController charCon;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;
    void Start()
    {
        
    }

    
    void Update()
    {
        isGrounded =Physics.CheckSphere(groundCheck.position,groundDistance,groundMask);

        if (isGrounded == true && velocity.y < 0) 
        {
            velocity.y = -2f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        charCon.Move(move*speed*Time.deltaTime);

        if (Input.GetKey(KeyCode.Space)) 
        {
            if(isGrounded == true) 
            {
              velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
            
        }

        velocity.y += gravity * Time.deltaTime;
        charCon.Move(velocity *Time.deltaTime);



    }
}
