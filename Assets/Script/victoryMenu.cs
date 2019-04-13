using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class victoryMenu : MonoBehaviour
{
    public void victory()
    {
        SceneManager.LoadScene("Main Menu");

    }

    public void restart()

    {
        SceneManager.LoadScene("Level One");
    }
}