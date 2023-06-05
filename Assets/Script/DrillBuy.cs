using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrillBuy : MonoBehaviour
{
    public GameObject panel;
    public RaycastHit hit;
    public Money money;
    public DrillTotal drill_script;
    
    
    void Start()
    {
        
    }


    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5)) 
        {
            if (hit.transform.CompareTag("shop"))
            {
                if (Input.GetKey(KeyCode.F)) 
                {
                    panel.SetActive(true);
                    Cursor.lockState = CursorLockMode.None;
                }
                

            }

            if (!Input.GetKey(KeyCode.F)) 
            {
                panel.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
            }

        }
    }

    public void BuyIronDrill() 
    {
        money.cash -= 50;
        drill_script.iron_drill += 1;
    }
}
