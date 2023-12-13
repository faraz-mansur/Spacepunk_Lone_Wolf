using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    public StatusPlayer statusPlayer;
 
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet")
        {
            // Debug.Log("Player hit by Enemy");
            statusPlayer.health -= 2.5f;
        }
        if (other.gameObject.tag == "EnvObject")
        {
            // Debug.Log("Player Collision with environment object");
            statusPlayer.health -= 2.5f;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "EnemyBullet")
        {
            // Debug.Log("Player hit by Enemy");
            statusPlayer.health -= 2.5f;
        }
        if (collision.gameObject.tag == "EnvObject")
        {
            // Debug.Log("Player Collision with environment object");
            statusPlayer.health -= 2.5f;
        }
    }
}