using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject EnemyPrefab;
    //public Transform[] spawnPoints;
    public int xPos;
    public int zPos;
    public int enemyCount;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawn());
        //SpawnEnemy();
    }

    private void OnEnable()
    {
        //Enemy.OnEnemyKilled += SpawnEnemy;
    }

    IEnumerator EnemySpawn()
    {
        while(enemyCount < 10)
        {
            xPos = Random.Range(1, 4);
            zPos = Random.Range(1, 56);
            Instantiate(EnemyPrefab, new Vector3(xPos, 2, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1; 
        }
    }




}
