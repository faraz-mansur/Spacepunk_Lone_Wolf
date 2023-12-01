using UnityEngine;

public class Example : MonoBehaviour
{
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        // speed = speed * -1;
        Debug.Log("Collision");
    }
}