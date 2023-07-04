using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField] Slider soundSlider;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("soundVolume"))
        {
            PlayerPrefs.SetFloat("soundVolume", 1);
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
        AudioListener.volume = soundSlider.value;
    }
    public void Load()
    {   
        soundSlider.value = PlayerPrefs.GetFloat("soundVolume");
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("soundVolume", soundSlider.value);
    }
}
    