using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilRigBuilding : MonoBehaviour
{
    public Transform oil_pos;
    public GameObject[] oil_building;
    public float[] price;
    public Money money_script;
    public float money;
    public bool[] build;

    
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
               Instantiate(oil_building[0], oil_pos);
               money_script.cash -= price[0];
               build[0] = true;
            }
        }
    
    }

    public void OilPhase2()
    {
        if (money >= price[1])
        {
            if(build[0] == true && build[1] == false)
            {

                Instantiate(oil_building[1], oil_pos);
                oil_building[0].SetActive(false);
                money_script.cash -= price[1];
                build[1] = true;
            }
        }

    }

    public void OilPhase3()
    {
        if (money >= price[2])
        {
            if(build[0] == true && build[1] == true && build[2] == false)
            {
                
                Instantiate(oil_building[2], oil_pos);
                oil_building[1].SetActive(false);
                money_script.cash -= price[2];
                build[2] = true;
            }
        }

    }
}
