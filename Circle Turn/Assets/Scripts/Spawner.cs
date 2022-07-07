using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
    [SerializeField] Vector2 range;
    [SerializeField] GameObject bonus;
    [SerializeField] GameObject enemy;
    

    void Start()
    {
        StartCoroutine(Spawn());
        
    }
    IEnumerator Spawn()
    {
        
        for (int i = 0;i<=1; i++)
        { yield return new WaitForSeconds(1);
            Vector2 pos = spawnPos.position + new Vector3(0, Random.Range(-range.y, range.y));
            Instantiate(enemy, pos, Quaternion.identity);
            yield return new WaitForSeconds(0);
        }
        yield return new WaitForSeconds(1);
        Vector2 pos2 = spawnPos.position + new Vector3(0, Random.Range(range.y, -range.y));
        Instantiate(bonus, pos2, Quaternion.identity);

        Repeat();
    }

    

    void Repeat()
    {
        StartCoroutine(Spawn());
       
    }
}
