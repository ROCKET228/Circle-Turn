using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int money;
    public int earnedMoney;
    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        earnedMoney = PlayerPrefs.GetInt("Score");
        money = money + earnedMoney;
        moneyText.text = money.ToString();
        PlayerPrefs.SetInt("Money",money);
        PlayerPrefs.SetInt("Score",0);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Shop()
    {
        SceneManager.LoadScene(3);
    }
}
