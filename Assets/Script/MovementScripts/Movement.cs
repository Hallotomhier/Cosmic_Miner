using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 move;
    public float speed;
    public float sprintSpeed;
    public OilRigBuilding oilRig;
    public bool upgrade_active;
    void Start()
    {
        
    }


    void Update()
    {
        upgrade_active = oilRig.upgrade;
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        move.x = x;
        move.z = y;
        transform.Translate(move * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = sprintSpeed;
        }
        else 
        {
            speed = 5;
        
        }
        if (upgrade_active == true) 
        {
            sprintSpeed = 10;
        
        
        }

        

    }
}
