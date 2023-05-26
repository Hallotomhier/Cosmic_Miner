using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hpbuilding : MonoBehaviour
{
    public float[] price;
    public float money;

    public bool[] build;
    public bool upgrade;

    public GameObject[] hp_building;
    public GameObject[] hp_button;

    public Money money_script;

    public bool is_build1;
    public bool is_build2;
    public bool is_build3;


    void Update()
    {
        money = money_script.cash;
        Save();
    }

    public void HpPhase1()
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

    public void HpPhase2()
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

    public void HpPhase3()
    {
        if (money >= price[2])
        {
            if (build[0] == true && build[1] == true && build[2] == false)
            {
                
                money_script.cash -= price[2];
                is_build3 = true;
                
            }
        }
    }



    public void Save() 
    {
        if (is_build1 == true) 
        {
            hp_building[0].SetActive(true);
            build[0] = true;
            hp_button[0].SetActive(false);
            hp_button[1].SetActive(true);

        }

        if (is_build2 == true)
        {
            hp_building[1].SetActive(true);
            hp_building[0].SetActive(false);
            build[1] = true;
            hp_button[0].SetActive(false);
            hp_button[1].SetActive(false);
            hp_button[2].SetActive(true);
            is_build1 = false;
        }

        if (is_build3 == true)
        {
            hp_building[2].SetActive(true);
            hp_building[1].SetActive(false);
            build[2] = true;
            hp_button[0].SetActive(false);
            hp_button[1].SetActive(false);
            hp_button[2].SetActive(false);
            is_build2 = false;

        }



    }

}


