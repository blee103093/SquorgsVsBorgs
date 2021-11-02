using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    public float speed;

    public float maxDistance;

    public ParticleSystem deathParticles;
    public Score playerScore;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed);
        maxDistance += 1 * Time.deltaTime;

        if(maxDistance >= 3)
        {
            Destroy(this.gameObject);
        }
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            //playerScore.AddScore(10);
            Destroy(other.gameObject);
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }
     
}
