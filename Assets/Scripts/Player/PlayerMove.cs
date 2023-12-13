using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public LevelMovement levelMovement;
    public bool throttle => Input.GetKey(KeyCode.Space);

    public float maxSpeed = 50f;
    public float minSpeed = 15f;

    public float acceleration = 5f;
    public float deceleration = 10f;

    public StatusPlayer statusPlayer;
    public float zRotationSpeed,
        zMaxRotation,
        xRotationSpeed,
        xMaxRotation;

    private Vector3 PlayerMovementInput;
    private Vector3 m_EulerAngleVelocity;

    [SerializeField]
    private Rigidbody PlayerBody;

    [SerializeField]
    private float Speed;

    [SerializeField]
    private float Sensitivity;

    // enginePower

    // private float zAngle = 0,
        // xAngle = 0;

    public float xRange = 20;
    public float yRange = 20;

    // private void Start()
    // {
    //     m_EulerAngleVelocity = new Vector3(100, 0, 100);
    // }

     // if the player collides with another rigidbody, destroy the player


    private void Update()
    {

        // if the player hits spacebar, increase the speed of the level
        if (throttle && statusPlayer.boost > 0f)
        {
            if (levelMovement.enginePower < maxSpeed)
            {
                levelMovement.enginePower += acceleration;
                statusPlayer.boost -= 1f;
            }
            else
            {
                statusPlayer.boost -= 1f;
            }
        }

        else if ((!throttle && levelMovement.enginePower > minSpeed) || (statusPlayer.boost <= 0f && levelMovement.enginePower > minSpeed))
        {
            if (levelMovement.enginePower - deceleration < minSpeed)
            {
                levelMovement.enginePower = minSpeed;
            }
            else
            {
                levelMovement.enginePower -= deceleration;
            }
        }

        // For Cursor Movement

        // Cursor.visible = false;
        // Cursor.lockState = CursorLockMode.Locked;
        // float h = Input.GetAxis("Mouse X");
        // float v = Input.GetAxis("Mouse Y");
        // PlayerBody.transform.Translate(h * Speed, v * Speed, 0);

        // For Key Movement

        PlayerMovementInput = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0f
        );

        MovePlayer();

        if (PlayerBody.transform.position.x > xRange)
        {
            PlayerBody.transform.position = new Vector3(
                xRange,
                PlayerBody.transform.position.y,
                PlayerBody.transform.position.z
            );
        }
        if (PlayerBody.transform.position.x < -xRange)
        {
            PlayerBody.transform.position = new Vector3(
                -xRange,
                PlayerBody.transform.position.y,
                PlayerBody.transform.position.z
            );
        }
        if (PlayerBody.transform.position.y > yRange)
        {
            PlayerBody.transform.position = new Vector3(
                PlayerBody.transform.position.x,
                yRange,
                PlayerBody.transform.position.z
            );
        }
        if (PlayerBody.transform.position.y < 4.5)
        {
            PlayerBody.transform.position = new Vector3(
                PlayerBody.transform.position.x,
                4.5f,
                PlayerBody.transform.position.z
            );
        }
    }

    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerBody.transform.Translate(MoveVector * Time.deltaTime, Space.World);
        // PlayerBody.velocity = new Vector3(MoveVector.x, MoveVector.y, PlayerBody.velocity.z);
        // float targetZRotation = Mathf.Clamp(
        //     Input.GetAxis("Horizontal") * zRotationSpeed * Time.deltaTime,
        //     -zMaxRotation,
        //     zMaxRotation
        // );
        // float targetXRotation = Mathf.Clamp(
        //     Input.GetAxis("Vertical") * xRotationSpeed * Time.deltaTime,
        //     -xMaxRotation,
        //     xMaxRotation
        // );

        // zAngle = Mathf.Lerp(zAngle, targetZRotation, Time.deltaTime);
        // xAngle = Mathf.Lerp(xAngle, targetXRotation, Time.deltaTime);

        // zAngle = targetZRotation;
        // xAngle = targetXRotation;

        // // Apply rotation
        // transform.rotation = Quaternion.Euler(-xAngle, 0, -zAngle);
    }

    // private void FixedUpdate()
    // {
    //     Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
    //     PlayerBody.MoveRotation(PlayerBody.rotation * deltaRotation);
    // }
}
