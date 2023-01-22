using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        SaveVolumePrefs();
    }

    private void LoadVolumePrefs()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Start()
    {
        if (PlayerPrefs.HasKey("musicVolume"))
        {
            LoadVolumePrefs();
        }
        else
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            LoadVolumePrefs();
        }
    }
    private void SaveVolumePrefs()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

}
