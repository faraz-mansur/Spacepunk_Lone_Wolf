using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collectable collected!");
        this.gameObject.SetActive(false);
    }
}