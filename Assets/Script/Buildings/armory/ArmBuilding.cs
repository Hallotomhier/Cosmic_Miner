using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmBuilding : MonoBehaviour
{
    public float[] price;
    public float money;

    public bool[] build;
    public bool upgrade;

    public GameObject[] arm_building;
    public GameObject[] arm_button;

    public Money money_script;


    void Update()
    {
        money = money_script.cash;
    }

    public void ArmPhase1()
    {
        if (money >= price[0])
        {
            if (build[0] == false)
            {
                arm_building[0].SetActive(true);
                money_script.cash -= price[0];
                build[0] = true;
                arm_button[0].SetActive(false);
                arm_button[1].SetActive(true);
            }
        }
    }

    public void ArmPhase2()
    {
        if (money >= price[1])
        {
            if (build[0] == true && build[1] == false)
            {
                arm_building[1].SetActive(true);
                arm_building[0].SetActive(false);
                money_script.cash -= price[1];
                build[1] = true;
                arm_button[1].SetActive(false);
                arm_button[2].SetActive(true);
            }
        }
    }

    public void ArmPhase3()
    {
        if (money >= price[2])
        {
            if (build[0] == true && build[1] == true && build[2] == false)
            {
                arm_building[2].SetActive(true);
                arm_building[1].SetActive(false);
                money_script.cash -= price[2];
                build[2] = true;
                arm_button[2].SetActive(false);
            }
        }
    }



}


