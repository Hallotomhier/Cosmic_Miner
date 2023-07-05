using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O2building : MonoBehaviour
{
    public float[] price;
    public float money;

    public bool[] build;
    public bool[] upgrade;

    public GameObject[] o2_building;
    public GameObject[] o2_button;

    public Money money_script;

    public bool is_build1;
    public bool is_build2;
    public bool is_build3;

    //music
    public GameObject buySound;
    public GameObject clickBackUI;
    public GameObject clickUI;


    void Update()
    {
        money = money_script.cash;
        Save();
    }

    public void O2Phase1()
    {
        if (money >= price[0])
        {
            if (build[0] == false)
            {
                money_script.cash -= price[0];
                is_build1 = true;

                clickUI.SetActive(false);
                clickUI.SetActive(true);
                buySound.SetActive(false);
                buySound.SetActive(true);

            }
        }
        else
        {
            clickBackUI.SetActive(false);
            clickBackUI.SetActive(true);
        }
    }

    public void O2Phase2()
    {
        if (money >= price[1])
        {
            if (build[0] == true && build[1] == false)
            {
                money_script.cash -= price[1];
                is_build2 = true;

                clickUI.SetActive(false);
                clickUI.SetActive(true);
                buySound.SetActive(false);
                buySound.SetActive(true);         
            }
        }
        else
        {
            clickBackUI.SetActive(false);
            clickBackUI.SetActive(true);
        }
    }

    public void O2Phase3()
    {
        if (money >= price[2])
        {
            if (build[0] == true && build[1] == true && build[2] == false)
            {
                money_script.cash -= price[2];
                is_build3 = true;

                clickUI.SetActive(false);
                clickUI.SetActive(true);
                buySound.SetActive(false);
                buySound.SetActive(true);
            }
        }
        else
        {
            clickBackUI.SetActive(false);
            clickBackUI.SetActive(true);
        }
    }


    public void Save() 
    {
        if (is_build1 == true) 
        {
            o2_building[0].SetActive(true);
            build[0] = true;
            o2_button[0].SetActive(false);
            o2_button[1].SetActive(true);
            upgrade[0] = true;


        }

        if (is_build2 == true)
        {
            o2_building[1].SetActive(true);
            o2_building[0].SetActive(false);
            build[1] = true;
            o2_button[0].SetActive(false);
            o2_button[1].SetActive(false);
            o2_button[2].SetActive(true);
            is_build1 = false;
            upgrade[0] = true;
            upgrade[1] = true;
        }

        if (is_build3 == true)
        {
            o2_building[2].SetActive(true);
            o2_building[1].SetActive(false);
            build[2] = true;
            o2_button[0].SetActive(false);
            o2_button[1].SetActive(false);
            o2_button[2].SetActive(false);
            is_build2 = false;
            upgrade[0] = true;
            upgrade[1] = true;
            upgrade[2] = true;
        }
    }



}


