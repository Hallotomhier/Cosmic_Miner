using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScreenRes : MonoBehaviour
{
    public GameObject fsOn;
    // public GameObject dropDown;
    public int dropDownValue;
    // public Dropdown dropDown;
    // public GameObject label;
   
    // Start is called before the first frame update
    void Start()
    {
        // Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);




        // Screen.fullScreen = false;
        fsOn.GetComponent<Toggle>().isOn = true;
        // dropDown = GetComponent<Dropdown>();
        // Debug.Log(dropDown.value);
        // Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }
    void Update()
    {
        // dropDownValue = GetComponent<Dropdown>().value;
    }
    public void FullScreen(bool fsOn)
    {
        Screen.fullScreen = fsOn;
        Debug.Log("fullscreen is " + fsOn);
    }
    // public void ResolutionChange()
    // {
    //     if(dropDown.GetComponent<Dropdown>().value == 0)
    //     {
    //         Screen.SetResolution(720, 480, FullScreenMode.Windowed);
    //         fsOn.GetComponent<Toggle>().isOn = false;
    //         Debug.Log("hey0");
    //     }
    //     if(dropDown.GetComponent<Dropdown>().value == 1)
    //     {
    //         Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
    //         fsOn.GetComponent<Toggle>().isOn = false;       
    //     }
    //             if(dropDown.GetComponent<Dropdown>().value == 2)
    //     {
    //         Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
    //         fsOn.GetComponent<Toggle>().isOn = false;       
    //     }
    //     if(dropDown.GetComponent<Dropdown>().value == 3)
    //     {
    //         Screen.SetResolution(2560, 1440, FullScreenMode.Windowed);
    //         fsOn.GetComponent<Toggle>().isOn = false;  
    //     }
        
    //     // if(label.GetComponent<>() == "1920 x 1080")
    //     // {
    //         //  Debug.Log("HEY");
    //     // }
        
    // }
    public void Resolution1()
    {
        Screen.SetResolution(720, 480, FullScreenMode.Windowed);
        fsOn.GetComponent<Toggle>().isOn = false;
    }
    public void Resolution2()
    {
        Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
        fsOn.GetComponent<Toggle>().isOn = false;
    }
    public void Resolution3()
    {
        Screen.SetResolution(1960, 1080, FullScreenMode.Windowed);
        fsOn.GetComponent<Toggle>().isOn = false;
    }
    public void Resolution4()
    {
        Screen.SetResolution(2560, 1440, FullScreenMode.Windowed);
        fsOn.GetComponent<Toggle>().isOn = false;
    }
}