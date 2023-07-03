using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketBuild : MonoBehaviour
{
    public OilRigBuilding orb;
    public O2building ob;
    public RmBuilding rb;
    public Money money_script;

    public bool[] build;
    public bool[] is_build;

    public float oil;
    public float[] price;

    public GameObject[] rck_building;
    public GameObject[] rck_button;


    void Start()
    {

    }


    void Update()
    {
        oil = money_script.oil;
        SaveThis();
    }

    public void Rocket1()
    {
        if (oil >= price[0])
        {
            if (build[0] == false)
            {
                money_script.oil -= price[0];
                is_build[0] = true;
            }
        }
    }

    public void Rocket2()
    {
        if (oil >= price[1])
        {
            if (build[0] == true && build[1] == false)
            {
                money_script.oil -= price[1];
                is_build[1] = true;
            }
        }
    }

    public void Rocket3()
    {
        if (oil >= price[2])
        {
            if (build[0] == true && build[1] == true && build[2] == false)
            {
                money_script.oil -= price[2];
                is_build[2] = true;
            }
        }
    }

    public void SaveThis() 
    {
        if (is_build[0] == true) 
        {
            rck_building[0].SetActive(true);
            build[0] = true;
            rck_button[0].SetActive(false);
            rck_button[1].SetActive(true);
        }

        if (is_build[1] == true)
        {
            rck_building[1].SetActive(true);
            rck_building[0].SetActive(false);
            build[1] = true;
            rck_button[0].SetActive(false);
            rck_button[1].SetActive(false);
            rck_button[2].SetActive(true);
            is_build[0] = false;
        }

        if (is_build[2] == true)
        {
            rck_building[2].SetActive(true);
            rck_building[1].SetActive(false);
            build[2] = true;
            rck_button[0].SetActive(false);
            rck_button[1].SetActive(false);
            rck_button[2].SetActive(false);
            is_build[1] = false;
        }
    }

}
