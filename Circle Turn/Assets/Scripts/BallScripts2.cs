using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallScripts2 : MonoBehaviour
{
    public int score;
    public bool isMulti;
    public bool isShield;
    [SerializeField] Text scoreText;
    public GameObject bonusEffecet;


    public void Start()
    {
        isMulti = PlayerPrefs.GetInt("isMulti") == 1 ? true : false;
        isShield = PlayerPrefs.GetInt("isShield") == 1 ? true : false;
        score = PlayerPrefs.GetInt("Score");


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
            Instantiate(bonusEffecet, transform.position, Quaternion.identity);
            if (isMulti == true)
            {
                score += 2;

            }
            else
                score++;
        }
        else if (other.gameObject.tag == "Enemy" && isShield == false)
        {

            PlayerPrefs.SetInt("Score", score);
            isMulti = false;
            PlayerPrefs.SetInt("isMulti", isMulti ? 1 : 0);
            SceneManager.LoadScene(2);
        }

        else if (other.gameObject.tag == "Enemy" && isShield == true)
        {
            Destroy(other.gameObject);
            isShield = false;
            PlayerPrefs.SetInt("isShield", isShield ? 1 : 0);
        }
    }

    void Update()
    {
        
        scoreText.text = score.ToString();
    }
}
