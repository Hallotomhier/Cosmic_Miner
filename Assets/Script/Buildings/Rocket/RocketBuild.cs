using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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

    public GameObject[] rck_button;

    //music
    public GameObject buySound;
    public GameObject clickBackUI;
    public GameObject clickUI;

    public GameObject winScreen;
    public GameObject screenUI;
    public GameObject player;
    public GameObject camera;
    public GameObject menu;


    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
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

    public void Rocket2()
    {
        if (oil >= price[1])
        {
            if (build[0] == true && build[1] == false)
            {
                money_script.oil -= price[1];
                is_build[1] = true;

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

    public void Rocket3()
    {
        if (oil >= price[2])
        {
            if (build[0] == true && build[1] == true && build[2] == false)
            {
                money_script.oil -= price[2];
                is_build[2] = true;

                clickUI.SetActive(false);
                clickUI.SetActive(true);
                buySound.SetActive(false);
                buySound.SetActive(true);
                
                winScreen.SetActive(true);
                screenUI.SetActive(false);
                player.GetComponent<Move>().enabled = false;
                camera.GetComponent<CamRot>().enabled = false;
                menu.SetActive(false);
            }
        }
        else
        {
            clickBackUI.SetActive(false);
            clickBackUI.SetActive(true);
        }
    }

    public void SaveThis() 
    {
        if (is_build[0] == true) 
        {
            build[0] = true;
            rck_button[0].SetActive(false);
            rck_button[1].SetActive(true);
        }

        if (is_build[1] == true)
        {
           
            build[1] = true;
            is_build[0] = false;
            rck_button[0].SetActive(false);
            rck_button[1].SetActive(false);
            rck_button[2].SetActive(true);
        }

        if (is_build[2] == true)
        {
            build[2] = true;
            is_build[1] = false;
            rck_button[0].SetActive(false);
            rck_button[1].SetActive(false);
            rck_button[2].SetActive(false);

        }
    }
   

}
