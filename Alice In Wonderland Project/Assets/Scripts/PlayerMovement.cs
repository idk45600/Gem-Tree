using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float moveSpeed;
    [SerializeField] Transform orientation;
    float horizontalInput;
    float verticalInput;
    Vector3 moveDirection;
    Rigidbody rigbody;
    private bool reverse;

    // Start is called before the first frame update
    void Start()
    {
        rigbody = GetComponent<Rigidbody>();
        rigbody.freezeRotation = true;
    }
    private void PlayerInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

    }
    private void MovePlayer()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rigbody.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }
    private void reversemove()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rigbody.AddForce(-moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

    public  void Reversecontrols(bool truOrFalse)
    {
        reverse = truOrFalse;
    }
    public Transform GetOrientation()
    {
        return orientation;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();

    }
    private void FixedUpdate()
    {
        if (reverse == true)
        {
            reversemove();
        }
        else {
            MovePlayer();
        }
        
    }
}
