using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Build : MonoBehaviour
{
    public Transform build_Pos;
    public GameObject build;
    public Money money_script;
    public float money;
    public float price;

    public void Update()
    {
        money = money_script.cash;
        
    }




    public void ButtonPressed() 
    { 
        if(money >= price)
        {
            Instantiate(build, build_Pos);
           money_script.cash -= price;
        }
    
    
    
    
    
    
    }





}
