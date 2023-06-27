using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject settingsMenu;
    public GameObject player;
    // public bool paused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Escape))
        // {   
        //     if(menu.activeSelf) 
        //     //  && settingsMenu.activeSelf
        //     {
        //         menu.SetActive(false);
        //         settingsMenu.SetActive(true);
        //         player.SetActive(false);
        //         // paused = true;
        //         Cursor.lockState = CursorLockMode.None;
        //         Debug.Log("if");
        //     }
        //     else
        //     {
        //         menu.SetActive(true);
        //         settingsMenu.SetActive(false);
        //         player.SetActive(true);
        //         // paused = false;
        //         Cursor.lockState = CursorLockMode.Locked;
        //         Debug.Log("else");
        //     }
        // }
        
    }
}
