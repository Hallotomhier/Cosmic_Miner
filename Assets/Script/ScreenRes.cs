using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenRes : MonoBehaviour
{
    public GameObject fsOn;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
        // Screen.fullScreen = false;
        fsOn.GetComponent<Toggle>().isOn = false;
    }
    public void Resolution1()
    {
        Screen.SetResolution(1280, 720, FullScreenMode.Windowed);
        // Screen.fullScreen = false;
        fsOn.GetComponent<Toggle>().isOn = false;
    }
    public void Resolution2()
    {
        Screen.SetResolution(1920, 1080, FullScreenMode.Windowed);
        // Screen.fullScreen = false;
        fsOn.GetComponent<Toggle>().isOn = false;
    }
    public void Resolution3()
    {
        Screen.SetResolution(2560, 1440, FullScreenMode.Windowed);
        // Screen.fullScreen = false;
        fsOn.GetComponent<Toggle>().isOn = false;
    }
    public void FullScreen(bool fsOn)
    {
        Screen.fullScreen = fsOn;
        Debug.Log("fullscreen is " + fsOn);
    }
}