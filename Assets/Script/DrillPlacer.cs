using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrillPlacer : MonoBehaviour
{
    public Transform[] location;
    public GameObject iron_Drill_Asset;
    public GameObject gold_Drill_Asset;
    public GameObject platinum_Drill_Asset;
    public RaycastHit hit;
    public float iron_drill;

    void Start()
    {
        Debug.Log("start");
    }

    
    void Update()
    {
        PlaceDrill();

        GetComponent<DrillInventory>().iron_drill = iron_drill;
    }



    public void PlaceDrill() 
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 5f))
        {

            if (Input.GetKeyDown(KeyCode.E)) 
            {
                Debug.Log(hit.transform.position);
                if (hit.transform.CompareTag("IronMine")) 
                {
                    Instantiate(iron_Drill_Asset, location[1]);
                    Debug.Log("Placed");
                
                
                
                
                
                }
            
            
            
            
            
            
            
            
            
            
            
            
            }
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        }
    
    
    }
}
