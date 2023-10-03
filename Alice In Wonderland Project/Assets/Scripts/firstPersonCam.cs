using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonCam : MonoBehaviour
{
    [SerializeField] float sensX;
    [SerializeField] float sensY;
    [SerializeField] Transform orientation;
    private float xRotation;
    private float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;
        yRotation += mX;
        xRotation -= mY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
