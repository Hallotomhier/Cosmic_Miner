using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldDrillEarn : MonoBehaviour
{
    public Money _money;

    public GameObject gold_drill;
    public Transform player;

    public float total_earn;
    public float gold_earn_cash;

    void Update()
    {
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
