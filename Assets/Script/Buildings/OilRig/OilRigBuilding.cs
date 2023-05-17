using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OilRigBuilding : MonoBehaviour
{
    public GameObject[] oil_building;
    public float[] price;
    public Money money_script;
    public float money;
    public bool[] build;
    public GameObject[] oil_button;
    public bool upgrade;
   







    

    
    void Update()
    {
        money = money_script.cash;
    }




    public void OilPhase1() 
    {
        if(money >= price[0]) 
        {
            if(build[0] == false)
            {
                oil_building[0].SetActive(true);
                money_script.cash -= price[0];
                build[0] = true;
                oil_button[0].SetActive(false);
                oil_button[1].SetActive(true);

            }
        }
    
    }

    public void OilPhase2()
    {
        if (money >= price[1])
        {
            if(build[0] == true && build[1] == false)
            {

                oil_building[1].SetActive(true);
                oil_building[0].SetActive(false);
                money_script.cash -= price[1];
                build[1] = true;
                oil_button[1].SetActive(false);
                oil_button[2].SetActive(true);
            }
        }

    }

    public void OilPhase3()
    {
        if (money >= price[2])
        {
            if(build[0] == true && build[1] == true && build[2] == false)
            {
                
                oil_building[2].SetActive(true);
                oil_building[1].SetActive(false);
                money_script.cash -= price[2];
                build[2] = true;
                upgrade = true;
                oil_button[2].SetActive(false);
            }
        }

    }
}
