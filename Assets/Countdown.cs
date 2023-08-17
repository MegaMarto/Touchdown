using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Countdown : MonoBehaviour
{
    public float timeRemaining = 240;

    public GameObject Player1Wins;
    public GameObject Player2Wins;
    public GameObject PlayersAreEven;



    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        
        else if (timeRemaining <= 0)
        {
            GameOverScreen();
        }
        


    }
    void GameOverScreen()
    {
        if(ScoreScript.scoreValue < ScoreScript2.scoreValue)
        {
            Player1Wins.SetActive(true);
        }
        else if (ScoreScript.scoreValue > ScoreScript2.scoreValue)
        {
            Player2Wins.SetActive(true);
        }
        else if (ScoreScript.scoreValue == ScoreScript2.scoreValue)
        {
            PlayersAreEven.SetActive(true);
        }
    }
}
