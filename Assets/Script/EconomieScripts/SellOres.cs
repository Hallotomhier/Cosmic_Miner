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
        ores.cash += ores.iron * ironSellPrice;
        ores.iron = 0;
    }

    public void SellGold() 
    {
        ores.cash += ores.gold * goldSellPrice;
        ores.gold = 0;
    }

    public void SellDiamond() 
    {
        ores.cash += ores.diamond * diamondSellPrice;
        ores.diamond = 0;
    }


}
