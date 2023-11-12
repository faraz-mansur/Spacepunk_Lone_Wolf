using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject bullet;
    // Update is called once per frame
    
    // if the bullet rigidbody collides with another rigidbody, destroy the bullet
    void OnCollisionEnter(Collision collision)
    {
        Destroy(bullet);
    }

}
