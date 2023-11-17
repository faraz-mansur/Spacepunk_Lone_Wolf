using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;

    void onTriggerEnter(Collider other)
    {
        if (this.tag == "Currency")
        {
            coinFX.Play();
            Debug.Log("Coin Collected");
            this.gameObject.SetActive(false);
        }
    }
}
