using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public CharacterController charCon;
    public float speed;
    public float gravity = -9.81f;
    public float jumpHeight;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;
    public float sprintSpeed;

    public bool[] upgrade;
    public ArmBuilding armory;
    void Start()
    {
        
    }

    
    void Update()
    {
        upgrade[0] = armory.upgrade[0];
        upgrade[1] = armory.upgrade[1];
        upgrade[2] = armory.upgrade[2];




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

        if (Input.GetKey(KeyCode.LeftShift) && upgrade[0] == true)
        {
            speed = sprintSpeed;
        }
        else 
        {
            speed = 12f;
        }

        Upgrade();

    }


    public void Upgrade() 
    {
        if (upgrade[1] == true)
        {
            sprintSpeed = 14f;
        }

        if (upgrade[2] == true)
        {
            sprintSpeed = 17f;
        }

    }
}
