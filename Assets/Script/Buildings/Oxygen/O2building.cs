using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2building : MonoBehaviour
{
    public float[] price;
    public float money;

    public bool[] build;
    public bool upgrade;

    public GameObject[] o2_building;
    public GameObject[] o2_button;

    public Money money_script;


    void Update()
    {
        money = money_script.cash;
    }

    public void O2Phase1()
    {
        if (money >= price[0])
        {
            if (build[0] == false)
            {
                o2_building[0].SetActive(true);
                money_script.cash -= price[0];
                build[0] = true;
                o2_button[0].SetActive(false);
                o2_button[1].SetActive(true);
            }
        }
    }

    public void O2Phase2()
    {
        if (money >= price[1])
        {
            if (build[0] == true && build[1] == false)
            {
                o2_building[1].SetActive(true);
                o2_building[0].SetActive(false);
                money_script.cash -= price[1];
                build[1] = true;
                o2_button[1].SetActive(false);
                o2_button[2].SetActive(true);
            }
        }
    }

    public void O2Phase3()
    {
        if (money >= price[2])
        {
            if (build[0] == true && build[1] == true && build[2] == false)
            {
                o2_building[2].SetActive(true);
                o2_building[1].SetActive(false);
                money_script.cash -= price[2];
                build[2] = true;
                o2_button[2].SetActive(false);
            }
        }
    }



}


