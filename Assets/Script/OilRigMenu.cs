using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilRigMenu : MonoBehaviour
{
    public GameObject oil_rig_panel;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            oil_rig_panel.SetActive(true);
            GetComponent<Movement>().enabled = false;
            GetComponent<MouseMovement>().enabled = false;
        }
        else 
        {
            oil_rig_panel.SetActive(false);
            GetComponent<Movement>().enabled = true;
            GetComponent<MouseMovement>().enabled = true;
        }
    }
}
