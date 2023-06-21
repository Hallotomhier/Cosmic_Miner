using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilRigMenu : MonoBehaviour
{
    public GameObject interact;
    public GameObject oil_rig_panel;
    public Transform player;
    void Update()
    {
        
    }

    
    void OnTriggerStay(Collider player)
    {
        interact.SetActive(true);
        if (Input.GetKey(KeyCode.E))
        {
            Cursor.lockState = CursorLockMode.None;
            oil_rig_panel.SetActive(true);
            

        }

        if (!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            oil_rig_panel.SetActive(false);
        }

    }

    private void OnTriggerExit(Collider player)
    {
        interact.SetActive(false);
        oil_rig_panel.SetActive(false); 
    }
}
