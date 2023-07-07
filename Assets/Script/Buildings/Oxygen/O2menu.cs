using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class O2menu : MonoBehaviour
{
    public GameObject interact;
    public GameObject o2_panel;
    public Transform player;
    
    public TMP_Text buildingInfo;

    void Update()
    {
        
    }

    void OnTriggerStay(Collider player)
    {
        interact.SetActive(true);
        if(Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.None;
            o2_panel.SetActive(true);
            Debug.Log("f");
        }
        
        if(!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            o2_panel.SetActive(false);
            Debug.Log("niet");
            buildingInfo.text = "";
        }
    }

    private void OnTriggerExit(Collider player)
    {
        interact.SetActive(false);
        o2_panel.SetActive(false);
        buildingInfo.text = "";
    }
}
