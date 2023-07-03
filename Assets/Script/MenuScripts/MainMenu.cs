using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject menu;
    // public GameObject menuMusic;
    // public GameObject clickBackUI;
    
    // Start is called before the first frame update
    void Start()
    {
        // menuMusic.SetActivate(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape) && menu.activeSelf)
        {   
            mainMenu.SetActive(true);
            settingsMenu.SetActive(false);
            // clickBackUi.SetActivate(false);
            // clickBackUi.SetActivate(true);
        }
    }
    
}
