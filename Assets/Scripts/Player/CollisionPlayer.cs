using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    public Rigidbody playerRb;
    private StatusPlayer statusPlayer;

    private void Start()
    {
        statusPlayer = playerRb.GetComponent<StatusPlayer>();
    }

    void onTriggerEnter(Collider other)
    {
        // if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet" || other.gameObject.tag == "EnvObject")
        // {
            Debug.Log("Collision on player");
            statusPlayer.health -= 50;
            Debug.Log("Player health: " + statusPlayer.health);
        // }
    }

    // void onTriggerStay(Collider other)
    // {
    //     if (other.gameObject.tag == "Enemy")
    //     {
    //         print("Collision");
    //     }
    // }

    // void onTriggerExit(Collider other)
    // {
    //     if (other.gameObject.tag == "Enemy")
    //     {
    //         print("Collided with enemy");
    //     }
    // }
}
