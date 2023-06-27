using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hp_O2 : MonoBehaviour
{
    [Range(0,200)]public float oxygen = 50f;
    [Range(0,100)]public float health = 100f;
    public float maxOxygen;
    public Slider oxygen_slider;
    public Slider health_slider;
    public Vector3 respawn_pos;
    public AirSystem airsystem;
    public bool insideair;
    public Transform player;
    public Money money;
    public GameObject bloodUI;
    public GameObject deathScreen;

    public O2building oxygenbuild;
    
    
    void Update()
    {
        insideair = airsystem.inside_Air;
        Hp();
        O2();
        oxygen_slider.value = oxygen;
        health_slider.value = health;

        if (oxygenbuild.upgrade[0] == true) 
        {
            
            maxOxygen = 100f;
        }
        if (oxygenbuild.upgrade[1] == true)
        {
            
            maxOxygen = 150f;
        }
        if (oxygenbuild.upgrade[2] == true)
        {
            
            maxOxygen = 200f;
        }

    }

    public void O2() 
    {
        if(insideair == false && oxygen > 0) 
        {
            oxygen -= 0.5f * Time.deltaTime;
        }

        if (insideair == true) 
        {
            oxygen = maxOxygen;
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
            player.transform.position = respawn_pos;
            health = 100;
            money.cash -= 200;
            deathScreen.SetActive(true);
            gameObject.SetActive(false);
            Debug.Log("You died!");
            
        }
        if(health <= 30) 
        {
            bloodUI.SetActive(true);     
        }
        else
        {
            bloodUI.SetActive(false);     
        }
    }
}
