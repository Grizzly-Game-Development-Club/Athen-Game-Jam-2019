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

    public void SetSoundEffectsVolume(float volume)
    {
        audioMixer.SetFloat("soundEffectsVolume", volume);
    }

    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("musicVolume", volume);
        slider = GameObject.FindGameObjectWithTag("slider").GetComponent<Slider>();
        if (slider.value == -30)
        {
            audioMixer.SetFloat("musicVolume", -80);
        }
    }
}
