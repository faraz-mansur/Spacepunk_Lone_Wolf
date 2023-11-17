using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject bullet;
    // Update is called once per frame
    
    // if the bullet rigidbody collides with another rigidbody, destroy the bullet
 void onTriggerEnter(Collider other)
    {
        Debug.Log("Collision with bullet");
        Destroy(bullet);
    }
}
