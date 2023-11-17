using UnityEngine;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (this.tag == "Currency")
        {
            Debug.Log("Currency Collected");
            this.gameObject.SetActive(false);
        }
    }
}