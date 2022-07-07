using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float speed;
    private int score;
  

     void FixedUpdate()
     {
        
        enemy.transform.Translate(speed * Time.deltaTime, 0, 0);
    }


}
