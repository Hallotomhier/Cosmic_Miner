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


    void Update()
    {
        money = money_script.cash;
    }

    public void RmPhase1()
    {
        if (money >= price[0])
        {
            if (build[0] == false)
            {
                rm_building[0].SetActive(true);
                money_script.cash -= price[0];
                build[0] = true;
                rm_button[0].SetActive(false);
                rm_button[1].SetActive(true);
                
            }
        }
    }

    public void RmPhase2()
    {
        if (money >= price[1])
        {
            if (build[0] == true && build[1] == false)
            {
                rm_building[1].SetActive(true);
                rm_building[0].SetActive(false);
                money_script.cash -= price[1];
                build[1] = true;
                rm_button[1].SetActive(false);
                rm_button[2].SetActive(true);
            }
        }
    }

    public void RmPhase3()
    {
        if (money >= price[2])
        {
            if (build[0] == true && build[1] == true && build[2] == false)
            {
                rm_building[2].SetActive(true);
                rm_building[1].SetActive(false);
                money_script.cash -= price[2];
                build[2] = true;
                rm_button[2].SetActive(false);
            }
        }
    }



}


