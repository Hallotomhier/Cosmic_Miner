using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drill : MonoBehaviour
{
    public RaycastHit hit;

    public GameObject _Ore;

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
                if (Input.GetKey(KeyCode.E)) 
                {
                    hit.transform.GetChild(0).gameObject.SetActive(true);
                    GetComponent<DrillTotal>().iron_drill -= 1;
                    _Ore.tag = "IronMineActive";

                }
            
            }
        }
    }
}
