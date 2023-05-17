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


    void Update()
    {
        money = money_script.cash;
    }

    public void HpPhase1()
    {
        if (money >= price[0])
        {
            if (build[0] == false)
            {
                hp_building[0].SetActive(true);
                money_script.cash -= price[0];
                build[0] = true;
                hp_button[0].SetActive(false);
                hp_button[1].SetActive(true);
            }
        }
    }

    public void HpPhase2()
    {
        if (money >= price[1])
        {
            if (build[0] == true && build[1] == false)
            {
                hp_building[1].SetActive(true);
                hp_building[0].SetActive(false);
                money_script.cash -= price[1];
                build[1] = true;
                hp_button[1].SetActive(false);
                hp_button[2].SetActive(true);
            }
        }
    }

    public void HpPhase3()
    {
        if (money >= price[2])
        {
            if (build[0] == true && build[1] == true && build[2] == false)
            {
                hp_building[2].SetActive(true);
                hp_building[1].SetActive(false);
                money_script.cash -= price[2];
                build[2] = true;
                hp_button[2].SetActive(false);
            }
        }
    }



}


