using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopAssist : MonoBehaviour
{
    public int money;
    public Text moneyText;
    private bool isMulti=false;
    private bool isShield = false;

    void Start()
    {
        money = PlayerPrefs.GetInt("Money");
    }

     void Update()
    {
        moneyText.text = money.ToString(); 
    }

    public void BuyMulti()
    {
        if(money>=10 && isMulti==false)
        {
            isMulti = true;
            money-=10;
            PlayerPrefs.SetInt("Money",money);
            PlayerPrefs.SetInt("isMulti", isMulti ? 1 : 0);
        }
    }

    public void BuyShield()
    {
        if (money >= 5 && isShield == false)
        {
            isShield = true;
            money -= 5;
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("isShield", isShield ? 1 : 0);
        }
    }

    public void ExitShop()
    {
        SceneManager.LoadScene(0);
    }

}
