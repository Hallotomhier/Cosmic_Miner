using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 move;
    public float speed;
    void Start()
    {
        
    }

    
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        move.x = x;
        move.z = y;
        transform.Translate(move * speed * Time.deltaTime);
    }
}
