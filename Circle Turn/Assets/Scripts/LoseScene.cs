using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseScene : MonoBehaviour
{
    public int score;
    public int bestscore=0;
    public Text scoreText;
    public Text bestscoreText;

    private void Start()
    {
        score = PlayerPrefs.GetInt("Score");
        bestscore = PlayerPrefs.GetInt("Best Score");

        if (score > bestscore)
        {
            PlayerPrefs.SetInt("Best Score", score);
        }

        scoreText.text = score.ToString();
        bestscoreText.text = bestscore.ToString();

    }

    
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ToGame()
    {
        SceneManager.LoadScene(1);
    }
}
