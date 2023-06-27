using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirSystem : MonoBehaviour
{
    public Transform player;
    public bool inside_Air;
    public O2building oxygenbuild;
    public hp_O2 o2;
   

    private void Update()
    {
        
    }
    public void OnTriggerStay(Collider player)
    {

        inside_Air = true;

    }

    public void OnTriggerExit(Collider player)
    {
        inside_Air = false;
        
    }
}
