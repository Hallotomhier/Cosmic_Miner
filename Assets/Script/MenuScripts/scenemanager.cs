using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{   
    public GameObject deathScreen;
    public GameObject menu;
    public GameObject settingsMenu;
    public GameObject player;
    public GameObject saveLoad;
    public Data save;
    public GameObject menuMusic;
    public GameObject gameMusic;
    public GameObject clickBackUI;
    public GameObject tutorial;
    
     
    
    void Start()
    {
        if(tutorial.activeSelf)
        {
            // Cursor.lockState = CursorLockMode.None;
            Debug.Log("tutiral oN");
        }
    }
    void Update()
    {
        if (tutorial.activeSelf) 
            {
                Cursor.lockState = CursorLockMode.None;
            }
            
        else if(Input.GetKeyDown(KeyCode.Escape))
        {
            
                if(deathScreen.activeSelf)
                {
                    deathScreen.SetActive(false);
                    Debug.Log("DeathScreen disabled.");
                    saveLoad.GetComponent<hp_O2>().enabled = true; 
                }
                else
                {
                    if(menu.activeSelf)
                    {
                        menu.SetActive(false);
                        settingsMenu.SetActive(true);
                        player.SetActive(false);
                        // paused = true;
                        Cursor.lockState = CursorLockMode.None;
                        Debug.Log("Paused the game.");
                        menuMusic.SetActive(true);
                        gameMusic.SetActive(false);
                        saveLoad.GetComponent<hp_O2>().enabled = false;
                    }
                    else
                    {
                        menu.SetActive(true);
                        settingsMenu.SetActive(false);
                        player.SetActive(true);
                        // paused = false;
                        Cursor.lockState = CursorLockMode.Locked;
                        Debug.Log("Unpaused the game.");
                        menuMusic.SetActive(false);
                        gameMusic.SetActive(true);
                        clickBackUI.SetActive(false);
                        clickBackUI.SetActive(true);
                        saveLoad.GetComponent<hp_O2>().enabled = true;
                    }
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
    public void SaveAndQuit()
    {
        save.Save();
        Application.Quit();
        Debug.Log("SaveAndQuit");
    }
}
