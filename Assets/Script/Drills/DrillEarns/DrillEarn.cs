using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillEarn : MonoBehaviour
{
    public Money _money;
    public GameObject rm_stand;
    

    public GameObject iron_drill;
    public Transform player;

    public float total_earn;
    public float iron_earn_cash;

    public bool upgrade;

    void Update()
    {
        upgrade = rm_stand.GetComponent<RmBuilding>().upgrade;


        if(upgrade == true) 
        {
            iron_earn_cash = 2f;        
        }

        if (iron_drill.activeInHierarchy) 
        {
            total_earn += iron_earn_cash * Time.deltaTime;   
        }
    }

    public void OnTriggerEnter(Collider player)
    {
        _money.iron += total_earn;
        total_earn = 0;
    }
}
