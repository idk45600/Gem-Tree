using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float moveSpeed;
    [SerializeField] Transform orientation;
    [SerializeField] float drag;
    [SerializeField] float playerHeight;
    [SerializeField] LayerMask Isground;
    bool grounded;
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
    private void controlSpeed()
    {
        Vector3 flatvel = new Vector3(rigbody.velocity.x, 0f, rigbody.velocity.z);
        if(flatvel.magnitude> moveSpeed)
        {
            Vector3 limtedval = flatvel.normalized * moveSpeed;
            rigbody.velocity = new Vector3(limtedval.x, rigbody.velocity.x, limtedval.z);
        }
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
        controlSpeed();
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f+0.2f,Isground);

        if (grounded)
        {
            rigbody.drag = drag;

        }
        else
        {
            rigbody.drag = 0;
        }

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
