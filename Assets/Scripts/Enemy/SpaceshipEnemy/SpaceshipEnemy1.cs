using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESS1 : MonoBehaviour
{
   public float forwardSpeed;

   public float turnSpeed;
   public Transform target;
   public float minimumDistance;

   public Rigidbody EnemyBody;

void FixedUpdate()
   {
      float distance = Vector3.Distance(transform.position,target.position); // get distance between target and enemy
      // follow target on x and y axis only at turnSpeed
      transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.position.x, target.position.y, transform.position.z), turnSpeed * Time.deltaTime);
      // Vector3 MoveVector = transform.TransformDirection(new Vector3(target.position.x, target.position.y, 0f)) * turnSpeed;
      // EnemyBody.transform.Translate(MoveVector * Time.deltaTime, Space.World);

      // if distance is greater than minimum distance
      if(distance > minimumDistance)
      {
         // move towards target
         transform.position = Vector3.MoveTowards(transform.position, target.position, forwardSpeed * Time.deltaTime);
      }

   }

}
