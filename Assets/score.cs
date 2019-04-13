using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {

    //public score;
    public Text scoreText;
    public int enemyScoreEarned;
    public int playerScore;


    void addToScore(int scoreAdded)
    {
        playerScore = playerScore + enemyScoreEarned;
        updateScoreGUI();
    }

    void updateScoreGUI()
    {
        scoreText.text = playerScore.ToString("0");
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            addToScore(enemyScoreEarned);
        }
    }

}
