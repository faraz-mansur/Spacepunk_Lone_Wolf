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

    // void OnCollisionEnter(Collision collision)
    // {
    //     Debug.Log("Collision");
    //     statusPlayer.health -= 50;
    // }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Collision");
            statusPlayer.health -= 50;
        }
    }
    void onTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            print("Collision");
            statusPlayer.health -= 50;
        }
    }

    void onTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            print("Collision");
        }
    }

    void onTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            print("Collision");
        }
    }
}
