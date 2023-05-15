using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IronDrill : MonoBehaviour
{
    public float earn_money;
    public GameObject ore;
    public RaycastHit hit;
    public GameObject drill;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        var cast = Physics.Raycast(transform.position, transform.forward, out hit, 5f);

        if (cast) 
        {
            ore = hit.transform.gameObject;
            if (ore.CompareTag("Iron") && Input.GetKey(KeyCode.E)) 
            {
                drill = ore.transform.GetChild(0).gameObject;
                drill.SetActive(true);
                ore.tag = "IronMineActive";
            }
        }
    }
}
