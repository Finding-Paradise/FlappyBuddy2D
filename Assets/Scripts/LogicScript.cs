using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    bool gameHasEnded = false;
    public int playerScore;
    public Text scoreText;
    [SerializeField] private AudioSource deathSoundEffect;
    public void addScore(int scoreToAdd)
    {
        playerScore+=scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            deathSoundEffect.Play();
            gameHasEnded = true;
            Invoke("Restart", .1f);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
