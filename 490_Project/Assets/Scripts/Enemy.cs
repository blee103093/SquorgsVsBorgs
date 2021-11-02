using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public delegate void EnemyKilled();
    public static event EnemyKilled OnEnemyKilled;
    private void OnTriggerEnter(Collider Enemy)
    {
        Destroy(Enemy.gameObject);
        Destroy(gameObject);

        if (Enemy.gameObject.CompareTag("Enemy"))
        {
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
