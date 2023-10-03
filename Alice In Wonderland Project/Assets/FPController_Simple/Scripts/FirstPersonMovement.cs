using System.Collections.Generic;
using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;

    [Header("Running")]
    public float runSpeed = 9;

    FirstPersonInput fPInput;

    CharacterController cController;
    Rigidbody rBody;

    void Awake()
    {
        // Get the rigidbody on this.
        cController = GetComponent<CharacterController>();
        fPInput = GetComponent<FirstPersonInput>();
    }

    void Update()
    {
        // Get targetMovingSpeed.
        float targetMovingSpeed = fPInput.isSprinting ? runSpeed : speed;

        // Get targetVelocity from input.
        Vector2 targetVelocity = new Vector2(fPInput.moveVector.x * (targetMovingSpeed )* Time.deltaTime, fPInput.moveVector.y * (targetMovingSpeed ) * Time.deltaTime);

        // Apply movement.
        cController.Move(transform.rotation * new Vector3(targetVelocity.x, -9.8f * Time.deltaTime, targetVelocity.y));
    }
}