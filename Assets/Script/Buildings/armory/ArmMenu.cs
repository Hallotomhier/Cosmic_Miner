using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmMenu : MonoBehaviour
{
    public GameObject arm_panel;
    public Transform player;
    void Update()
    {
        if (!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            arm_panel.SetActive(false);
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.None;
            arm_panel.SetActive(true);
        }
    }

    
}
