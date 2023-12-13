using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoDisplay : MonoBehaviour
{
    public StatusPlayer statusPlayer;
    public int bulletsLeft, magazineSize;
    public TextMeshProUGUI scoreText;

    // Update is called once per frame
    void Update()
    {
        if (bulletsLeft != statusPlayer.bulletsLeft)
        {
            bulletsLeft = statusPlayer.bulletsLeft;
        }
        
        if (magazineSize != statusPlayer.magazineSize)
        {
            magazineSize = statusPlayer.magazineSize;
        }

        scoreText.text = bulletsLeft.ToString() + "/" + magazineSize.ToString();
    }
}
