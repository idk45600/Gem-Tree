using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonInput : MonoBehaviour
{
    public Vector2 moveVector;
    public Vector2 lookVector;
    public bool isSprinting;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Sprinting();
        MovementInput();
        LookInput();
    }

    void MovementInput() 
    {
        moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    void Sprinting() 
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            isSprinting = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprinting = false;
        }
    }

    void LookInput() 
    {
        lookVector = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
    }
}
