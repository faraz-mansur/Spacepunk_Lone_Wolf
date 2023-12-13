using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusPlayer : MonoBehaviour
{

    private bool _isDead = false;
    public float health = 100f;
    public float boost = 250f;
    public int score = 0;
    public int bulletsLeft, magazineSize; 
    public Rigidbody PlayerBody;

    void Update()
    {
        if (!_isDead)
        {
            if (health <= 0)
            {
                EndGame();
            }
        }

    }

    private void EndGame()
    {
        _isDead = true;
        Debug.Log("Game Over");
    }
}
