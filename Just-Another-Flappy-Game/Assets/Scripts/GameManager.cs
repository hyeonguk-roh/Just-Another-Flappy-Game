using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TMPro;

public class GameManager : MonoBehaviour
{
    private int score;
    private int highScore;

    public TMP_Text scoreText;
    public TMP_Text scoreText2;
    public TMP_Text highScoreText;

    public GameObject Panel;
    public GameObject scoreTextObject;
    
    void Start()
    {
        if (PlayerPrefs.HasKey("Highscore")) {
            highScore = PlayerPrefs.GetInt("Highscore");
        } else {
            PlayerPrefs.SetInt("Highscore", highScore);
        }
    }

    void Update()
    {
        PlayerPrefs.SetInt("Highscore", highScore);
    }

    public void GameOver()
    {
        Panel.SetActive(true);
        scoreTextObject.SetActive(false);
        highScoreText.text = highScore.ToString();
        scoreText2.text = score.ToString();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        if (score > highScore) {
            highScore = score;
        }
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("TheGame");
    }
}
