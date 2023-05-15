using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronMoney : MonoBehaviour
{
    public GameObject[] i_mine;
    public float earning;
    public float total_money;
    public Money money_earn;
    void Start()
    {
        
    }

    
    void Update()
    {
        total_money += money_earn.cash;

        if (i_mine[0].CompareTag("IronMineActive"))
        {
            earning += total_money * Time.deltaTime;


        }


    }
}
