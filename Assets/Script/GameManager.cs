using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_GameState { Start, Pause, Play, Victory, Defeat }

public class GameManager : MonoBehaviour
{
    public int score;
    public int time;
    public E_GameState gameState;
    public bool IsScrolling;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case E_GameState.Defeat:
                break;
            case E_GameState.Pause:
                break;
            case E_GameState.Play:
                break;
            case E_GameState.Start:
                break;
            case E_GameState.Victory:
                break;
        }
    }
}
