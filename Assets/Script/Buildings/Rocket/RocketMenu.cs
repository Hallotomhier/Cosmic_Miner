using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RocketMenu : MonoBehaviour
{
    public GameObject rocket_panel;
    public GameObject interact;
    public Transform player;

    public TMP_Text buildingInfo;

    void Start()
    {
        
    }


    void OnTriggerStay(Collider player)
    {
        interact.SetActive(true);
        if (Input.GetKey(KeyCode.F))
        {
            rocket_panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        else 
        {
            Cursor.lockState = CursorLockMode.Locked;
            rocket_panel.SetActive(false);
            buildingInfo.text = "";
        }
    }

    void OnTriggerExit(Collider player)
    {
        rocket_panel.SetActive(false);
        interact.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        buildingInfo.text = "";
    }
}
