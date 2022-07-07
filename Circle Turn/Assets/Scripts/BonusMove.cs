using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusMove : MonoBehaviour
{
    [SerializeField] GameObject bonus;
    [SerializeField] float bonusspeed;
    

    void FixedUpdate()
    {
        
        bonus.transform.Translate(bonusspeed * Time.deltaTime,0,0);
        

    }

    
}