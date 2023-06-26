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
     
    
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(deathScreen.activeSelf)
            {
                deathScreen.SetActive(false);
                Debug.Log("DeathScreen disabled.");
                saveLoad.GetComponent<hp_O2>().enabled = false;
            }
            else
            {
                if(menu.activeSelf) 
            //  && settingsMenu.activeSelf
            {
                menu.SetActive(false);
                settingsMenu.SetActive(true);
                player.SetActive(false);
                // paused = true;
                Cursor.lockState = CursorLockMode.None;
                Debug.Log("Paused the game.");
            }
            else
            {
                menu.SetActive(true);
                settingsMenu.SetActive(false);
                player.SetActive(true);
                // paused = false;
                Cursor.lockState = CursorLockMode.Locked;
                Debug.Log("Unpaused the game.");
            }
            }
        }
    }
    
    public void OnClick()
    {
        SceneManager.LoadScene(1);
    }

}
