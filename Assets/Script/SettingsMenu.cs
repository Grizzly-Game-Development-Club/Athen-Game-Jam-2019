using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

// Coded by: Justin Sandman

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    private UnityEngine.UI.Slider slider;

    public void SetMasterVolume(float volume)
    {
        ManageAudio("masterVolume", volume);
    }

    public void SetSoundEffectsVolume(float volume)
    {
        ManageAudio("soundEffectsVolume",volume);
    }

    public void SetMusicVolume(float volume)
    {
        ManageAudio("musicVolume", volume);
    }

    private void ManageAudio(string soundType, float volume)
    {
        audioMixer.SetFloat(soundType, volume);
        slider = GameObject.FindGameObjectWithTag("slider").GetComponent<Slider>();
        if (slider.value == -30)
        {
            audioMixer.SetFloat(soundType, -80);
        }
    }
}

