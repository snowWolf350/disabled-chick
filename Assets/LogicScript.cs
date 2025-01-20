using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text ScoreText;
    public GameObject GameOverScreen;
    public AudioSource DingSfx;
    public Text highscore;
    [ContextMenu("Increase")]
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("highscore", 0).ToString();
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape) == true)
        {
            Application.Quit();
        }
    }
    public void addScore(int ScoreToAdd)
    {
        DingSfx.Play();
        playerScore = playerScore + ScoreToAdd;
        ScoreText.text = playerScore.ToString();
        if (playerScore > PlayerPrefs.GetInt("highscore", 0))
        {   
            PlayerPrefs.SetInt("highscore", playerScore);
            highscore.text = playerScore.ToString();
        }
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {
        GameOverScreen.SetActive(true);
    }
}
