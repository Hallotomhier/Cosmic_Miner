using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class O2 : MonoBehaviour
{
    public Slider oxygen_slider;
    public float total_oxygen = 100f;
    
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        total_oxygen -= 0.5f * Time.deltaTime;
        oxygen_slider.value = total_oxygen;
        if (total_oxygen == 0) 
        {
            Debug.Log("Die");
        
        
        }
    }
}
