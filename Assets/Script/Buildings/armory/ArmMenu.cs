using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ArmMenu : MonoBehaviour
{
    public GameObject interact;
    public GameObject arm_panel;
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
            arm_panel.SetActive(true);
        }

        if (!Input.GetKey(KeyCode.F))
        {
            Cursor.lockState = CursorLockMode.Locked;
            arm_panel.SetActive(false);
            buildingInfo.text = "";
        }
    }

    private void OnTriggerExit(Collider player)
    {
        arm_panel.SetActive(false);
        interact.SetActive(false);
        buildingInfo.text = "";
    }


}
