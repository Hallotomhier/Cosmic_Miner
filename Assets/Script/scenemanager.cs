using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    public void OnClick()
    {
        SceneManager.LoadScene(1);
    }
}
