using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject settingsMenu;
    // public GameObject menu;
    public GameObject menuMusic;
    public GameObject clickBackUI;
    
    // Start is called before the first frame update
    void Start()
    {
        if(mainMenu.activeSelf)
        {
            menuMusic.SetActive(true);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(mainMenu.activeSelf) 
            //  && settingsMenu.activeSelf
            {
                // mainMenu.SetActive(false);
                // settingsMenu.SetActive(true);
                
                // // paused = true;
                    
                // Debug.Log("Paused the game.");
                // menuMusic.SetActive(true);
                // gameMusic.SetActive(false);     
            }
            else
            {   
                clickBackUI.SetActive(false);
                clickBackUI.SetActive(true); 
                mainMenu.SetActive(true);
                settingsMenu.SetActive(false);
                    
                // paused = false;
                    
                Debug.Log("Unpaused the game.");
                // menuMusic.SetActive(false);
                // gameMusic.SetActive(true);
                 
            }    
        }
    }
    public void OnClick()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

}
