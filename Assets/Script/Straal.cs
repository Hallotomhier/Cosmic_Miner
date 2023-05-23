using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Straal : MonoBehaviour
{
    public RaycastHit hit;
    public hp_O2 fill_o2;
    public GameObject cast_Hit;

    void Start()
    {
        
    }


    void Update()
    {
       
        OxygenFill();
        PlaceDrill();



    }



    void PlaceDrill() 
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5)) 
        {
            cast_Hit = hit.transform.gameObject;
            if (cast_Hit.CompareTag("Iron")) 
            {
                if (GetComponent<DrillTotal>().iron_drill >= 0) 
                {
                    cast_Hit.transform.GetChild(0).gameObject.SetActive(true);
                    GetComponent<DrillTotal>().iron_drill -= 1;
                    cast_Hit.tag = "IronMineActive";
                }
                



            }
        
        
        
        
        }
    
    
    
    
    }


















    void OxygenFill() 
    { 
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5)) 
        {
            
            if (hit.transform.CompareTag("Oxygen")) 
            {
                
                if (Input.GetKey(KeyCode.E)) 
                {
                    fill_o2.oxygen = 100;
                
                }
            
            }
        
        }
    }
    
    
    
    
}
