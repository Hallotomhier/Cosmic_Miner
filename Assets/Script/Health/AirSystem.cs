using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSystem : MonoBehaviour
{
    public Transform player;
    public bool inside_Air;
   


    public void OnTriggerStay(Collider player)
    {
        inside_Air = true;
    }

    public void OnTriggerExit(Collider player)
    {
        inside_Air = false;
        
    }
}
