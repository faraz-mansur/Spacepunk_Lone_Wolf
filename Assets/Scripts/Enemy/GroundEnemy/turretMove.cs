using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretMove : MonoBehaviour
{
    public Transform target;
    public float distance = 70;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) < distance)
        {
            transform.LookAt(target);
        };
    }
}
