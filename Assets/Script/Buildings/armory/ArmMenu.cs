using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArmMenu : MonoBehaviour
{
    public GameObject interact;
    public GameObject arm_panel;
    public Transform player;
    void Update()
    {
        
    }

    void OnTriggerStay(Collider player)
    {
        interact.SetActive(true);
        if (Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.None;
            arm_panel.SetActive(true);
        }

        if (!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            arm_panel.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider player)
    {
        arm_panel.SetActive(false);
        interact.SetActive(false);
    }


}
