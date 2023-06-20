using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldDrillEarn : MonoBehaviour
{
    public Money _money;
    public GameObject rm_stand;

    public GameObject gold_drill;
    public Transform player;

    public float total_earn;
    public float gold_earn_cash;

    public bool upgrade;

    void Update()
    {
        upgrade = rm_stand.GetComponent<RmBuilding>().upgrade2;

        if (upgrade == true) 
        {
            gold_earn_cash = 0.8f;
        }

        if (gold_drill.activeInHierarchy)
        {
            total_earn += gold_earn_cash * Time.deltaTime;
        }
    }

    public void OnTriggerEnter(Collider player)
    {
        _money.gold += total_earn;
        total_earn = 0;
    }
}
