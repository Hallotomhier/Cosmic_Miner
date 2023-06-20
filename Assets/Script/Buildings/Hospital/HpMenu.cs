using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpMenu : MonoBehaviour
{
    public GameObject hp_panel;
    public Transform player;
    void Update()
    {
        if (!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            hp_panel.SetActive(false);
        }
    }

    void OnTriggerStay(Collider player)
    {
        if (Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.None;
            hp_panel.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider player)
    {
        hp_panel.SetActive(false);
    }
}
