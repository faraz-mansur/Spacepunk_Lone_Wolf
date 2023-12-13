using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyStatusSS : MonoBehaviour
{
    public StatusPlayer statusPlayer;
    public float health = 150f;
    public bool isDead = false;
    public GameObject enemyExplosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (health <= 0)
        {
            enemyDeath();
            return;
        }
        // enemyDeath();

    }

    // private void onTriggerEnter (Collider other)
    // {
    //     if (other.gameObject.tag == "playerRayShot")
    //     {
    //         Debug.Log("Hit by player!");
    //         health -= 30;
    //     }
    //     else 
    //     {
    //         Debug.Log("Hit by something else!");
    //     }
    // }

    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.tag == "playerRayShot")
        {
            Debug.Log("Hit by player!");
            health -= 30;
            
        }
        else 
        {
            Debug.Log("Hit by something else!");
        }
    }

    private void enemyDeath()
    {
        isDead = true;
        Debug.Log("Enemy is dead");
        GameObject explosion = (GameObject)Instantiate(enemyExplosion, transform.position, transform.rotation);
        Destroy(gameObject);
        Destroy(explosion, 1f);
        statusPlayer.score += 15;
    }
}
