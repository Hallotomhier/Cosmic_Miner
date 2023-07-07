using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RmMenu : MonoBehaviour
{
    public GameObject interact;
    public GameObject rm_panel;
    public Transform player;

    public TMP_Text buildingInfo;

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
            buildingInfo.text = "";
        }
    }

    private void OnTriggerExit(Collider player)
    {
        interact.SetActive(false);
        rm_panel.SetActive(false);
        buildingInfo.text = "";
    }
}
