using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour
{
    public RaycastHit hit;
    
    public DrillTotal _drillTotal;
    public RmBuilding rm_building;
    public Money _money;

    public GameObject[] _ironDrill;
    public GameObject[] _goldDrill;
    public GameObject[] _diamondDrill;
    public GameObject[] _OilExtractor;
    public GameObject _Ore;

    public float iron_earn_cash;
    public float gold_earn_cash;
    public float diamond_earn_cash;
    public float oil_earn_cash;

    public bool[] iron_isActive;
    public bool[] gold_isActive;
    public bool[] diamond_isActive;
    public bool[] oil_isActive;




    void Start()
    {
        
    }

    
    void Update()
    {

        ToSave();
        GoldDrill();
        IronDrill();
        DiamondDrill();
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


            if (hit.transform.CompareTag("Gold"))
            {
                if (Input.GetKey(KeyCode.E) && _drillTotal.gold_drill >= 0)
                {
                    hit.transform.GetChild(0).gameObject.SetActive(true);
                    hit.transform.tag = "GoldMineActive";
                    _drillTotal.gold_drill -= 1;
                }

            }


            if (hit.transform.CompareTag("Diamond"))
            {
                if (Input.GetKey(KeyCode.E) && _drillTotal.diamond_drill >= 0)
                {
                    hit.transform.GetChild(0).gameObject.SetActive(true);
                    hit.transform.tag = "DiamondMineActive";
                    _drillTotal.diamond_drill -= 1;
                }

            }
        }
        
    }



    public void ToSave() 
    {
        if (iron_isActive[0] == true) 
        {
            _ironDrill[0].SetActive(true);
        }

        if (iron_isActive[1] == true)
        {
            _ironDrill[1].SetActive(true);
        }

        if (iron_isActive[2] == true)
        {
            _ironDrill[2].SetActive(true);
        }

        if (iron_isActive[3] == true)
        {
            _ironDrill[3].SetActive(true);
        }

    }


    public void IronDrill() 
    {
        if (rm_building.upgrade == true) 
        {
            iron_earn_cash = 2;
        
        }


        if (_ironDrill[0].activeInHierarchy)  
        {
            _money.iron += iron_earn_cash * Time.deltaTime;
            iron_isActive[0] = true;
        }
        if (_ironDrill[1].activeInHierarchy)
        {
            _money.iron += iron_earn_cash * Time.deltaTime;
            iron_isActive[1] = true;
        }
        if (_ironDrill[2].activeInHierarchy)
        {
            _money.iron += iron_earn_cash * Time.deltaTime;
            iron_isActive[2] = true;
        }
        if (_ironDrill[3].activeInHierarchy)
        {
            _money.iron += iron_earn_cash * Time.deltaTime;
            iron_isActive[3] = true;
        }
    }

    public void GoldDrill() 
    {
        if (_goldDrill[0].activeInHierarchy)
        {
            _money.gold += gold_earn_cash * Time.deltaTime;
            gold_isActive[0] = true;
        }
        if (_goldDrill[1].activeInHierarchy)
        {
            _money.gold += gold_earn_cash * Time.deltaTime;
            gold_isActive[1] = true;
        }
        if (_goldDrill[2].activeInHierarchy)
        {
            _money.gold += gold_earn_cash * Time.deltaTime;
            gold_isActive[2] = true;
        }
        if (_goldDrill[3].activeInHierarchy)
        {
            _money.gold += gold_earn_cash * Time.deltaTime;
            gold_isActive[3] = true;
        }

    }


    public void DiamondDrill() 
    { 
    
    
    
    
    }


}
