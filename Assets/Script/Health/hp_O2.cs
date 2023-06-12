using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp_O2 : MonoBehaviour
{
    [Range(0,100)]public float oxygen = 100f;
    [Range(0,100)]public float health = 100f;
    public Slider oxygen_slider;
    public Slider health_slider;
    public Vector3 respawn_pos;
    public AirSystem airsystem;
    public bool insideair;

    
    void Update()
    {
        insideair = airsystem.inside_Air;
        Hp();
        O2();
        oxygen_slider.value = oxygen;
        health_slider.value = health;
        
    }

    public void O2() 
    {
        if(insideair == false && oxygen > 0) 
        {
            oxygen -= 0.5f * Time.deltaTime;
            
        
        }
    
    }

    public void Hp() 
    {
        if(oxygen <= 0 && insideair == false)  
        {
            oxygen = 0;
            health -= 2f * Time.deltaTime;
            
        } 
        if(health <= 0) 
        {
            health = 0;
            Debug.Log("die");
            
        }
    
    }
}
