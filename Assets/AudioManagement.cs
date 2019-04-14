using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    [SerializeField] private static AudioManagement audioManagement;

    public AudioSource backgroundMusic;

    public AudioClip LevelOneMusic;
    public AudioClip MainMenuMusic;

    public static AudioManagement Instance
    {
        get
        {
            if (!audioManagement)
            {
                audioManagement = FindObjectOfType(typeof(AudioManagement)) as AudioManagement;

                if (!audioManagement)
                {
                    Debug.LogError("Error: There is no active Game Manager attached to a gameObject");
                }
                else
                {
                    audioManagement.Init();
                }
            }

            return audioManagement;
        }
        set
        {
            audioManagement = value;
        }
    }


    public void ChangeBackground(string name)
    {
        switch (name)
        {
            case "Main Menu":
                backgroundMusic.clip = MainMenuMusic;
                backgroundMusic.loop = true;
                backgroundMusic.Play();
                break;
            case "Level One":
                backgroundMusic.clip = LevelOneMusic;
                backgroundMusic.loop = true;
                backgroundMusic.Play();
                break;
            case "None":
                backgroundMusic.Stop();
                break;
        }
    }

    private void Awake()
    {
        Instance = Instance;
    }

    private void Init()
    {
        DontDestroyOnLoad(gameObject);
    }

}
