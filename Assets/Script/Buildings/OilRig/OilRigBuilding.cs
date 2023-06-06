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



    public bool is_build1;
    public bool is_build2;
    public bool is_build3;










    void Update()
    {
        money = money_script.cash;
        Save();
    }




    public void OilPhase1() 
    {
        if(money >= price[0]) 
        {
            if(build[0] == false)
            {
                
                money_script.cash -= price[0];
                is_build1 = true;
                

            }
        }
    
    }

    public void OilPhase2()
    {
        if (money >= price[1])
        {
            if(build[0] == true && build[1] == false)
            {

                
                money_script.cash -= price[1];
                is_build2 = true;
                
            }
        }

    }

    public void OilPhase3()
    {
        if (money >= price[2])
        {
            if(build[0] == true && build[1] == true && build[2] == false)
            {
                money_script.cash -= price[2];
                is_build3 = true;
                Debug.Log("OILRIG PHASE 3 pressed");
            }
        }

    }


    public void Save() 
    {

        if (is_build1 == true) 
        {
            oil_building[0].SetActive(true);
            build[0] = true;
            oil_button[0].SetActive(false);
            oil_button[1].SetActive(true);
        }

        if (is_build2 == true)
        {
            oil_building[1].SetActive(true);
            oil_building[0].SetActive(false);
            build[1] = true;
            oil_button[0].SetActive(false);
            oil_button[1].SetActive(false);
            oil_button[2].SetActive(true);
            is_build1 = false;

        }

        if (is_build3 == true)
        {
            oil_building[2].SetActive(true);
            oil_building[1].SetActive(false);
            build[2] = true;
            upgrade = true;
            oil_button[0].SetActive(false);
            oil_button[1].SetActive(false);
            oil_button[2].SetActive(false);
            is_build2 = false;
            Debug.Log(is_build3);

        }

    }




 
}
