using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellOres : MonoBehaviour
{
    public Money ores;
    public RaycastHit hit;

    public float ironSellPrice;
    public float goldSellPrice;
    public float diamondSellPrice;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5f)) 
        {
            if(Input.GetKey(KeyCode.E)) 
            {
                if (hit.transform.CompareTag("sell")) 
                {
                    ores.cash += ores.iron  * ironSellPrice;
                    ores.iron = 0;

                    ores.cash += ores.gold * goldSellPrice;
                    ores.gold = 0;

                    ores.cash += ores.diamond * diamondSellPrice;
                    ores.diamond = 0;
                
                }
            }
        }
    }
}
