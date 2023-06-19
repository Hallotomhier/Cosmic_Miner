using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondDrillEarn : MonoBehaviour
{
    public Money _money;

    public GameObject diamond_drill;
    public Transform player;

    public float total_earn;
    public float diamond_earn_cash;

    void Update()
    {
        if (diamond_drill.activeInHierarchy)
        {
            total_earn += diamond_earn_cash * Time.deltaTime;
        }
    }

    public void OnTriggerEnter(Collider player)
    {
        _money.diamond += total_earn;
        total_earn = 0;
    }
}
