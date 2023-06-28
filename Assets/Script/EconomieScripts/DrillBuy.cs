using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DrillBuy : MonoBehaviour
{
    public GameObject oil_stand;
    public GameObject panel;
    public RaycastHit hit;
    public Money money;
    public DrillTotal drill_script;
    public float[] price;
    public bool[] upgrade;
    public GameObject[] buttons;
    public Transform player;
    public GameObject interact;

    public Money ores;
    

    public float ironSellPrice;
    public float goldSellPrice;
    public float diamondSellPrice;

    void Update()
    {  
        UpgradeCheck();
        
    }

    public void OnTriggerStay(Collider player)
    {
        interact.SetActive(true);
        if (Input.GetKey(KeyCode.F))
        {
            panel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }

        if (!Input.GetKey(KeyCode.F))
        {
            panel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }

    }

    public void OnTriggerExit(Collider player)
    {
        panel.SetActive(false);
        interact.SetActive(false);
    }

    public void UpgradeCheck() 
    {
        upgrade[0] = oil_stand.GetComponent<OilRigBuilding>().upgrade[0];
        upgrade[1] = oil_stand.GetComponent<OilRigBuilding>().upgrade[1];
        upgrade[2] = oil_stand.GetComponent<OilRigBuilding>().upgrade[2];


        if(upgrade[0] == true) 
        {
            buttons[0].SetActive(true);
        }

        if (upgrade[1] == true)
        {
            buttons[1].SetActive(true);
        }

        if (upgrade[2] == true)
        {
            buttons[2].SetActive(true);
        }


    }

    public void BuyIronDrill() 
    {
        if(money.cash >= price[0]) 
        {
            money.cash -= price[0];
            drill_script.iron_drill += 1;
        }
        
    }

    public void BuyGoldDrill() 
    {
        if (money.cash >= price[1]) 
        {
            money.cash -= price[1];
            drill_script.gold_drill += 1;
        }
    }

    public void BuyDiamondDrill()
    {
        if (money.cash >= price[2])
        {
            money.cash -= price[2];
            drill_script.diamond_drill += 1;
        }
    }

    public void RefineOil() 
    {
        if (ores.iron >= 100 && ores.gold >= 100 && ores.diamond >= 100)  
        {
            ores.oil += 1;
            ores.iron -= 100;
            ores.gold -= 100;
            ores.diamond -= 100;
        }
    }

    public void SellOres() 
    {
        ores.cash += ores.iron * ironSellPrice;
        ores.iron = 0;

        ores.cash += ores.gold * goldSellPrice;
        ores.gold = 0;

        ores.cash += ores.diamond * diamondSellPrice;
        ores.diamond = 0;
    }
}
