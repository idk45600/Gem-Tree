using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teaCup : MonoBehaviour, Iinteractable
{
    private firstPersonCam firstPersonCam;
    private float presensx;
    private float presensy;
    Transform grabObjectPoint;
    [SerializeField] Transform pointToGoto;
    [SerializeField] float rotationSensitivity = 30;
    bool isPickedUp = false;
    public void Interact()
    {
        grabObjectPoint = pointToGoto;
        isPickedUp = true;
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    private void FixedUpdate()
    {
        if (grabObjectPoint != null)
        {
            this.gameObject.GetComponent<Rigidbody>().MovePosition(grabObjectPoint.position);
            this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                this.grabObjectPoint = null;
                this.gameObject.GetComponent<Rigidbody>().useGravity = true;
                isPickedUp = false;
            }
            if (Input.GetKey(KeyCode.F))
            {
                if (isPickedUp == true)
                {
                    firstPersonCam.sensX = 0f;
                    firstPersonCam.sensY = 0f;
                    float xAxisRotation = Input.GetAxis("Mouse X") * rotationSensitivity;
                    float yAxisRotation = Input.GetAxis("Mouse Y") * rotationSensitivity;
                    this.transform.Rotate(Vector3.down, xAxisRotation);
                    this.transform.Rotate(Vector3.right, yAxisRotation);
                }

            }
            if (Input.GetKeyUp(KeyCode.F))
            {
                firstPersonCam.sensX = presensx;
                firstPersonCam.sensY = presensy;


            }
        }
    }
}
