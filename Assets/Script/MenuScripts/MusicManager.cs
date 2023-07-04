using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    public AudioSource menuMusic;
    public AudioSource gameMusic;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        else
        {
            Load();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeVolume()
    {
        // AudioListener.volume = volumeSlider.value;
        menuMusic.volume = volumeSlider.value;
        gameMusic.volume = volumeSlider.value;
    }
    public void Load()
    {   
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
    
}
