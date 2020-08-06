using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public GameObject SettingsCanvas;
    public GameObject MainMenuCanvas;

    public TextMeshProUGUI CurrentMasterValue;
    public TextMeshProUGUI CurrentMusicValue;
    public TextMeshProUGUI CurrentSFXValue;

    public void onMasterSlider(float volume)
    {
        CurrentMasterValue.text = volume.ToString();
        AudioController.setMasterVolume(volume / 100 * 80);
    }

    public void onMusicSlider(float volume)
    {
        CurrentMusicValue.text = ((int)(volume / 100 * 80)).ToString();
        AudioController.setMusicVolume(volume - 80);
    }

    public void onSFXSlider(float volume)
    {
        CurrentSFXValue.text = ((int)(volume / 100 * 80)).ToString();
        AudioController.setSFXVolume(volume - 80);
    }

    public void onBackClick()
    {
        MainMenuCanvas.SetActive(true);
        SettingsCanvas.SetActive(false);
    }
}
