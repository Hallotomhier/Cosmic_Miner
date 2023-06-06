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
    public float[] price;
    
    
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
        if(money.cash >= price[0]) 
        {
            money.cash =- price[0];
            drill_script.iron_drill += 1;
        }
        
    }
}
