using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioSource blip;
    public AudioSource lose;
    public bool audioPlay = true;
    public AudioSource playAgain;
    

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        blip.Play();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        playAgain.Play();
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        if(audioPlay)
        {
            lose.Play();
            audioPlay = false;
        }
        
    }
}
