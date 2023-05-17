using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class O2menu : MonoBehaviour
{
    public GameObject o2_panel;
    public Transform player;
    void Update()
    {
        if (!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            o2_panel.SetActive(false);
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.None;
            o2_panel.SetActive(true);
        }
    }
}
