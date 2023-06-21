using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RmMenu : MonoBehaviour
{
    public GameObject interact;
    public GameObject rm_panel;
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
            rm_panel.SetActive(true);
        }

        if (!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            rm_panel.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider player)
    {
        interact.SetActive(false);
        rm_panel.SetActive(false);
    }
}
