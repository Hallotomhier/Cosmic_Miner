using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpMenu : MonoBehaviour
{
    public GameObject interact;
    public GameObject hp_panel;
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
            hp_panel.SetActive(true);
        }

        if (!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            hp_panel.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider player)
    {
        interact.SetActive(false);
        hp_panel.SetActive(false);
    }
}
