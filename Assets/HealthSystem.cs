using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthSystem : MonoBehaviour
{
    public Slider healthBar;
   public StatusPlayer statusPlayer;

    // Update is called once per frame
    void Update()
    {
        if (healthBar.value != statusPlayer.health)
        {
            healthBar.value = statusPlayer.health;
        }
        
    }
}
