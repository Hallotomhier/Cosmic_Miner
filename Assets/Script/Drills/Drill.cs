using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour
{
    public RaycastHit hit;
    
    public DrillTotal _drillTotal;

    public GameObject[] _ironDrill;
    public GameObject _Ore;

    public Money _money;

    public float earn_cash;


    public RmBuilding rm_building;

    void Start()
    {
        
    }

    
    void Update()
    {
        
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5f)) 
        {
            _Ore = hit.transform.gameObject;
            if (hit.transform.CompareTag("Iron")) 
            {
                if (Input.GetKey(KeyCode.E) && _drillTotal.iron_drill >= 0) 
                {
                    hit.transform.GetChild(0).gameObject.SetActive(true);
                    hit.transform.tag = "IronMineActive";
                    _drillTotal.iron_drill -= 1;
                }
            
            }
        }
        IronDrill();
    }   



    public void IronDrill() 
    {
        if (rm_building.upgrade == true) 
        {
            earn_cash = 2;
        
        }


        if (_ironDrill[0].activeInHierarchy)  
        {
            _money.cash += earn_cash * Time.deltaTime;
        }
        if (_ironDrill[1].activeInHierarchy)
        {
            _money.cash += earn_cash * Time.deltaTime;
        }
        if (_ironDrill[2].activeInHierarchy)
        {
            _money.cash += earn_cash * Time.deltaTime;
        }
        if (_ironDrill[3].activeInHierarchy)
        {
            _money.cash += earn_cash * Time.deltaTime;
        }
    }


}
