using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    public GameObject settingsMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {   
            if(menu.activeSelf)
            {
                menu.SetActive(false);
                // settingsMenu.SetActive(true);
            }
            else
            {
                menu.SetActive(true);
                // settingsMenu.SetActive(false);
            }
        }
    }
}
