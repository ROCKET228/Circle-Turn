using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour
{
    [SerializeField] GameObject CenterCircle;
    [SerializeField] GameObject shield;
    bool direction = false;
    private bool isShield;

    void FixedUpdate()
    {
        isShield = PlayerPrefs.GetInt("isShield") == 1 ? true : false;
        if(isShield==false)
        {
            Destroy(shield.gameObject);
        }

        if (direction == false)
            CenterCircle.transform.Rotate(0, 0, 150 * Time.deltaTime);
        else
            CenterCircle.transform.Rotate(0, 0, -150 * Time.deltaTime);
    }
    
    public void ChangrDirection()
    {
        direction = !direction;
    }
}
