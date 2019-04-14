using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

// Coded by: Justin Sandman

public class SettingsMenuSc : MonoBehaviour
{
    public AudioMixer audioMixer;
    private UnityEngine.UI.Slider masterSlider;
    private UnityEngine.UI.Slider soundEffectSlider;
    private UnityEngine.UI.Slider musicSlider;
    public GameObject sliders;


    public void SetMasterVolume(float volume)
    {
        audioMixer.SetFloat("masterVolume", volume);
        masterSlider = GameObject.Find("MasterVolumeSlider").GetComponent<Slider>();
        if (masterSlider.value == -30)
        {
            audioMixer.SetFloat("masterVolume", -80);
        }
    }

    public void SetSoundEffectsVolume(float volume)
    {
        audioMixer.SetFloat("soundEffectsVolume", volume);
        soundEffectSlider = GameObject.Find("SoundEffectsVolumeSlider").GetComponent<Slider>();
        if (soundEffectSlider.value == -30)
        {
            audioMixer.SetFloat("soundEffectsVolume", -80);
        }
    }
    public void SetMusicVolume(float volume)
    {
        audioMixer.SetFloat("musicVolume", volume);
        musicSlider = GameObject.Find("MusicVolumeSlider").GetComponent<Slider>();
        if (musicSlider.value == -30)
        {
            audioMixer.SetFloat("musicVolume", -80);
        }
    }
}