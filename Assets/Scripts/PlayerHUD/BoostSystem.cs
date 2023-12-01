using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostSystem : MonoBehaviour
{
    public Slider boostBar;
    public StatusPlayer statusPlayer;

    // Update is called once per frame
    void Update()
    {
        
        if (boostBar.value != statusPlayer.boost)
        {
            // Debug.Log("Boost: " + statusPlayer.boost);
            boostBar.value = statusPlayer.boost;
        }
    }
}
