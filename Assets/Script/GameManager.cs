using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum E_GameState { Start, Pause, Play, Victory, Defeat }

public class GameManager : MonoBehaviour
{
    public int score;
    public int time;
    public E_GameState gameState;

    public GameObject backgroundScroller;
    public float scaleSpeed;
    public bool isScrolling;

    public GameObject victoryScreen;
    public GameObject deathScreen;
    public GameObject pauseScreen;
    public GameObject livePrefab;
    public GameObject liveHolder;

    public int seconds;
    public int minutes;

    public Text scoreText;
    public Text highscoreText;
    public Text timeDurationText;
    

    // Start is called before the first frame update
    void Start()
    {
        isScrolling = true;
        gameState = E_GameState.Play;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("0000000000");
        highscoreText.text = score.ToString("0000000000");


        minutes = (int)Time.timeSinceLevelLoad / 60;

        if ((int)Time.timeSinceLevelLoad >= 60)
        {
            seconds = ((int)Time.timeSinceLevelLoad - (minutes * 60));
        }
        else
        {
            seconds = (int)Time.timeSinceLevelLoad;
        }

        timeDurationText.text = minutes.ToString("00") + ":" + seconds.ToString("00");

        if (Input.GetKeyDown(KeyCode.Escape))
            togglePause();
        if (isScrolling)
            backgroundScroller.GetComponent<Rigidbody2D>().gravityScale = (scaleSpeed);
        else
            backgroundScroller.GetComponent<Rigidbody2D>().gravityScale = (0);


        switch (gameState)
        {
            case E_GameState.Defeat:
                deathScreen.SetActive(true);
                break;
            case E_GameState.Pause:
                pauseScreen.SetActive(true);
                Time.timeScale = 0f;
                break;
            case E_GameState.Play:
                pauseScreen.SetActive(false);
                Time.timeScale = 1f;
                break;
            case E_GameState.Start:
                break;
            case E_GameState.Victory:
                victoryScreen.SetActive(true);
                break;
        }
    }

    public void togglePause()
    {
        if (Time.timeScale == 0f)
        {
            gameState = E_GameState.Play;           
        }
        else
        {
            gameState = E_GameState.Pause;           
        }
    }

    public void addLive()
    {
        GameObject newLives = Instantiate(livePrefab, liveHolder.transform) as GameObject;

    }

    public void removeLive()
    {
        if (liveHolder.transform.childCount > 0)
        {
            GameObject lastChild = liveHolder.transform.GetChild(liveHolder.transform.childCount - 1).gameObject;
            Destroy(lastChild);
        }
        if (liveHolder.transform.childCount == 0)
        {
            gameState = E_GameState.Defeat;
        }
    }

}
