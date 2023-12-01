using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMovement : MonoBehaviour
{
    public float enginePower;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = transform.forward * enginePower * Time.deltaTime;
        transform.position -= movement; // Move the Level object
    }
}
