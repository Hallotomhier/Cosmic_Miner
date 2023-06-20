using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RmMenu : MonoBehaviour
{
    public GameObject rm_panel;
    public Transform player;
    void Update()
    {
        if (!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            rm_panel.SetActive(false);
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.None;
            rm_panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider player)
    {
        rm_panel.SetActive(false);
    }
}
