using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RmBuilding : MonoBehaviour
{
    public float[] price;
    public float money;

    public bool[] build;
    public bool upgrade;

    public GameObject[] rm_building;
    public GameObject[] rm_button;

    public Money money_script;

    public bool is_build1;
    public bool is_build2;
    public bool is_build3;


    public void Update()
    {
        money = money_script.cash;
        Save();
    }

    public void RmPhase1()
    {
        if (money >= price[0])
        {
            if (build[0] == false)
            {
                
                money_script.cash -= price[0];
                is_build1 = true;
                
                
            }
        }
    }

    public void RmPhase2()
    {
        if (money >= price[1])
        {
            if (build[0] == true && build[1] == false)
            {
                
                money_script.cash -= price[1];
                is_build2 = true;
                
            }
        }
    }

    public void RmPhase3()
    {
        if (money >= price[2])
        {
            if (build[0] == true && build[1] == true && build[2] == false)
            {
                
                money_script.cash -= price[2];
                
            }
        }
    }

    public void Save() 
    {
        if (is_build1 == true) 
        {
            rm_building[0].SetActive(true);
            build[0] = true;
            rm_button[0].SetActive(false);
            rm_button[1].SetActive(true);
            upgrade = true;
        }

        if (is_build2 == true)
        {
            rm_building[1].SetActive(true);
            rm_building[0].SetActive(false);
            build[1] = true;
            rm_button[0].SetActive(false);
            rm_button[1].SetActive(false);
            rm_button[2].SetActive(true);
            is_build1 = false;

        }

        if (is_build3 == true)
        {
            rm_building[2].SetActive(true);
            rm_building[1].SetActive(false);
            build[2] = true;
            rm_button[0].SetActive(false);
            rm_button[1].SetActive(false);
            rm_button[2].SetActive(false);
            is_build2 = false;
            
        }
    }



}


