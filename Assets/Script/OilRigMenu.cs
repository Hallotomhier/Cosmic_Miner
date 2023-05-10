using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilRigMenu : MonoBehaviour
{
    public GameObject oil_rig_panel;
    public Transform player;
    void Update()
    {
        if(!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            oil_rig_panel.SetActive(false);


        }
    }

    
    void OnTriggerStay(Collider player)
    {
        if (Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.None;
            oil_rig_panel.SetActive(true);
 
        }
        
    }
}
