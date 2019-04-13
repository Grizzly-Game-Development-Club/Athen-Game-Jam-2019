using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {

    public Text timeText;
    private int seconds;
    private int minutes;
	
	// Update is called once per frame
	void Update () {

        minutes = (int)Time.timeSinceLevelLoad / 60;

        if ((int)Time.timeSinceLevelLoad >= 60)
        {
            seconds = ((int)Time.timeSinceLevelLoad - (minutes * 60));
        }
        else
        {
            seconds = (int)Time.timeSinceLevelLoad;
        }

        timeText.text = minutes + ":" + seconds;

    }
}
