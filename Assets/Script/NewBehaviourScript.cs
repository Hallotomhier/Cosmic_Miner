using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform player;
    public Transform pullbackLoc;
    void Start()
    {
        
    }


    void OnTriggerEnter(Collider player)
    {
        player.transform.position = pullbackLoc.position;
    }
}
