using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmBuilding : MonoBehaviour
{
    public float[] price;
    public float money;

    public bool[] build;
    public bool[] upgrade;

    public GameObject[] arm_building;
    public GameObject[] arm_button;

    public Money money_script;

    public bool is_build1;
    public bool is_build2;
    public bool is_build3;


    void Update()
    {
        money = money_script.cash;
        Save();
    }

    public void ArmPhase1()
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

    public void ArmPhase2()
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

    public void ArmPhase3()
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
            arm_building[0].SetActive(true);
            build[0] = true;
            arm_button[0].SetActive(false);
            arm_button[1].SetActive(true);
            upgrade[0] = true;
        }

        if (is_build2 == true) 
        {
            arm_building[1].SetActive(true);
            arm_building[0].SetActive(false);
            build[1] = true;
            arm_button[0].SetActive(false);
            arm_button[1].SetActive(false);
            arm_button[2].SetActive(true);
            is_build1 = false;
            upgrade[0] = true;
            upgrade[1] = true;
            
        }

        if (is_build3 == true) 
        {
            arm_building[2].SetActive(true);
            arm_building[1].SetActive(false);
            build[2] = true;
            arm_button[0].SetActive(false);
            arm_button[1].SetActive(false);
            arm_button[2].SetActive(false);
            is_build2 = false;
            upgrade[0] = true;
            upgrade[1] = true;
            upgrade[2] = true;
        }
    
    
    
    }


}


