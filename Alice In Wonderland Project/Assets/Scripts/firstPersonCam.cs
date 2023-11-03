using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstPersonCam : MonoBehaviour
{
    public float sensX;
    public float sensY;
    [SerializeField] Transform orientation;
   // [SerializeField] GameObject go;
    private float xRotation;
    private float yRotation;
   // Ray ray;
    //RaycastHit hitData;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }
   /* public RaycastHit getHitData()
    {
        return hitData;
    }*/
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
