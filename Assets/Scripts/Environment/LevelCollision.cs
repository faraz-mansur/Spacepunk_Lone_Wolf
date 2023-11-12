using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCollision : MonoBehaviour
{

    private bool _isDead = false;
    private int health = 100;
    public Rigidbody PlayerBody;
    public Rigidbody LevelBody;

    void Update()
    {
        if (_isDead)
        {
            // If the player is dead, stop the Level from moving
            LevelBody.velocity = Vector3.zero;
            Debug.Log("Game Over"); 
        }
    }
    // This method is called when a collision occurs
    void OnCollisionEnter(Collision collision)
    {
        health -= 50;
        Debug.Log("Health: " + health);
        if (health <= 0)
        {
            _isDead = true;
            EndGame();
        }     
    }


    private void EndGame()
    {
        Debug.Log("Game Over"); 

    }
}
