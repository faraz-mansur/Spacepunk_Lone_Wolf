using UnityEngine;

public class CollisionPlayer : MonoBehaviour
{
    public StatusPlayer statusPlayer;
 
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet")
        {
            Debug.Log("Player hit by Enemy");
            statusPlayer.health -= 10;
        }
        if (other.gameObject.tag == "EnvObject")
        {
            Debug.Log("Player Collision with environment object");
            statusPlayer.health -= 5;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "EnemyBullet")
        {
            Debug.Log("Player hit by Enemy");
            statusPlayer.health -= 10;
        }
        if (collision.gameObject.tag == "EnvObject")
        {
            Debug.Log("Player Collision with environment object");
            statusPlayer.health -= 5;
        }
    }
}