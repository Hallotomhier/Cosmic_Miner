using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody rb;
    public RaycastHit hit;
    public bool grounded;
    public float force;
    

    
    void Update()
    {
        rb = GetComponent<Rigidbody>();
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 2f))
        {
            grounded = true;
        }
        else 
        {
            grounded = false;
        
        }
        if (grounded == true) 
        {
            if (Input.GetKey(KeyCode.Space)) 
            {
                rb.AddForce(Vector3.up * force, ForceMode.Force);
            
            }
        
        
        }
        
    }
}
