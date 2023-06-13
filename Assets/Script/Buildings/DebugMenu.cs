using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMenu : MonoBehaviour
{
    public Money money;
    public Movement move;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.M)) 
        {
            money.cash += 100;
        
        }

        if (Input.GetKey(KeyCode.LeftControl))
        {
            move.sprintSpeed = 15;

        }
        else
        {
            move.sprintSpeed=7;
        }
            
            
    }
}
