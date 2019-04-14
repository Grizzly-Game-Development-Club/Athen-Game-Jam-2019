using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicThing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("AudioSystem").GetComponent<AudioManagement>().ChangeBackground("Level One");
    }
}
