using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPlayer : MonoBehaviour
{

    private bool _isDead = false;
    public int health = 100;
    public Rigidbody PlayerBody;

    void Update()
    {
        if (health <= 0)
        {
            _isDead = true;
        }

        if (_isDead)
        {
            // If the player is dead, stop the Level from moving
            EndGame(); 
        }
    }
    // This method is called when a collision occurs
    // void OnCollisionEnter(Collision collision)
    // {
    //     health -= 50;
    //     Debug.Log("Health: " + health);
    //     if (health <= 0)
    //     {
    //         _isDead = true;
    //         EndGame();
    //     }     
    // }


    private void EndGame()
    {
        Debug.Log("Game Over"); 

    }
}
