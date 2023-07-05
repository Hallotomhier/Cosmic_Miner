using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellOres : MonoBehaviour
{
    public Money ores;
    public RaycastHit hit;

    public GameObject[] sell_button;
    public Hpbuilding shopUpgrade;

    public float ironSellPrice;
    public float goldSellPrice;
    public float diamondSellPrice;

    //music
    public GameObject coinSound;
    public GameObject clickBackUI;
    public GameObject clickUI;

    void Start()
    {
        
    }

    public void Update()
    {
        if (shopUpgrade.upgrade[1] == true) 
        {
            sell_button[0].SetActive(true);
        }

        if (shopUpgrade.upgrade[2] == true)
        {
            sell_button[1].SetActive(true);
        }


    }

    public void SellIron()
    {
        if(ores.iron > 0)
        {
            ores.cash += ores.iron * ironSellPrice;
            ores.iron = 0;

            clickUI.SetActive(false);
            clickUI.SetActive(true);
            coinSound.SetActive(false);
            coinSound.SetActive(true);
        }
        else
        {
            clickBackUI.SetActive(false);
            clickBackUI.SetActive(true);
        }
        

    }

    public void SellGold() 
    {
        if(ores.gold > 0)
        {
            ores.cash += ores.gold * goldSellPrice;
            ores.gold = 0;

            clickUI.SetActive(false);
            clickUI.SetActive(true);    
            coinSound.SetActive(false);
            coinSound.SetActive(true);
        }
        else
        {
            clickBackUI.SetActive(false);
            clickBackUI.SetActive(true);
        }
        
    }

    public void SellDiamond() 
    {
        if(ores.diamond > 0)
        {
            ores.cash += ores.diamond * diamondSellPrice;
            ores.diamond = 0;

            clickUI.SetActive(false);
            clickUI.SetActive(true);
            coinSound.SetActive(false);
            coinSound.SetActive(true);
        }
        else
        {
            clickBackUI.SetActive(false);
            clickBackUI.SetActive(true);
        }
        
    }


}
