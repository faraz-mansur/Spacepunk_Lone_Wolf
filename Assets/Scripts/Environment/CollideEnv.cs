using UnityEngine;

public class CollideEnv : MonoBehaviour
{

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Collision Environment with Player");
        }
    }
}