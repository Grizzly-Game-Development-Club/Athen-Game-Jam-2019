﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("AudioSystem").GetComponent<AudioManagement>().ChangeBackground("Main Menu");
    }

}
