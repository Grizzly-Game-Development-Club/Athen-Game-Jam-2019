using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagement : MonoBehaviour
{
    [SerializeField] private static AudioManagement audioManagement;

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

    private void Awake()
    {
        Instance = Instance;
    }

    private void Init()
    {
        DontDestroyOnLoad(gameObject);
    }

}
