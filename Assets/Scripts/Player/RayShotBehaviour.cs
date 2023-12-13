using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShotBehaviour : MonoBehaviour
{
    public GameObject bullet;
    public Vector3 m_target;
    public GameObject collisionExplosion;
    public float speed;

    // if the bullet rigidbody collides with another rigidbody, destroy the bullet

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerSpaceship")
        {
            Debug.Log("Enemy bullet hit player through OnCollisionEnter");
        }
        // Debug.Log("Hit registered for bullet for shot behaviour through OnCollisionEnter");
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Player bullet hit enemy through OnCollisionEnter");
            explode();
        }
        // Debug.Log(this.gameObject.tag);
        // Destroy(bullet);
        return;
    }

    private void onTriggerEnter(Collider other)
    {
        // Debug.Log("Hit registered for shot behaviour through onTriggerEnter");
        explode();
        Destroy(bullet);
        return;
    }

    // else if the bullet goes out of bounds, destroy the bullet
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 300f; // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;
        if (m_target != null)
        {
            // Debug.Log("Position: " + transform.position + " Target: " + m_target + " Step: " + step + "");
            if (transform.position == m_target)
            {
                // Debug.Log("Hit enemy BOOM!");
                explode();
                return;
            }
            transform.position = Vector3.MoveTowards(transform.position, m_target, step);
        }
        else if (
            bullet.transform.position.y > 100
            || bullet.transform.position.y < -100
            || bullet.transform.position.x > 100
            || bullet.transform.position.x < -100
            || bullet.transform.position.z > 100
            || bullet.transform.position.z < -100
        )
        {
            Destroy(bullet);
        }
    }

    public void setTarget(Vector3 target)
    {
        // Debug.Log("Target set: " + target + "");
        m_target = target;
    }

    void explode()
    {
        if (collisionExplosion != null)
        {
            GameObject explosion = (GameObject)Instantiate(
                collisionExplosion,
                transform.position,
                transform.rotation
            );
            Destroy(gameObject);
            Destroy(explosion, 1f);
        }
    }
}
