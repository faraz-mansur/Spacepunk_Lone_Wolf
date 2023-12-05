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
    }
}