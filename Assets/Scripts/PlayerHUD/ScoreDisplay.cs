using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    public StatusPlayer statusPlayer;
    public int score = 0;
    public TextMeshProUGUI scoreText;
    void Start()
    {
        scoreText.text = score.ToString();   
    }

    // Update is called once per frame
    void Update()
    {
        if (score != statusPlayer.score)
        {
            scoreText.text = statusPlayer.score.ToString();
        }
    }
}
