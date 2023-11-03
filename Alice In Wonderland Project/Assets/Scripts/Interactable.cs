using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] bool IsEndObject= true;
    [SerializeField] bool IsChessObject = false;
    [SerializeField] bool IsGrabObject = false;
    [SerializeField] bool IsPill1 = false;
    [SerializeField] bool door = false;
    [SerializeField] bool draw = false;
    [SerializeField] float rotationSensitivity=3000;
    Transform grabObjectPoint;
    SceneChanger SceneChanger;
    Vector3 moveDirection;
    PlayerMovement plamove;
    private float presensx;
    private float presensy;
    interactor intera;
    firstPersonCam firstPersonCam;
   [SerializeField] GameObject lockPick;
    //firstPersonCam cam;
    // Start is called before the first frame update
    void Start()
    {
        //  cam = FindFirstObjectByType<firstPersonCam>();
        SceneChanger = FindObjectOfType<SceneChanger>();
        firstPersonCam = FindObjectOfType<firstPersonCam>();
        plamove = FindObjectOfType<PlayerMovement>();
        intera = FindObjectOfType<interactor>();
        presensx = firstPersonCam.sensX;
        presensy = firstPersonCam.sensY;
    }
    public void Interact()
    {
        if (IsEndObject==true)
        {
            SceneChanger.loadNewScene();
        }
        if (IsChessObject== true)
        {
            moveDirection = plamove.GetOrientation().forward  + plamove.GetOrientation().right ;
            this.gameObject.GetComponent<Rigidbody>().AddForce(moveDirection.normalized * 20f * 10f, ForceMode.Force);
        }
        if (IsPill1== true)
        {
            plamove.Reversecontrols(true);
        }
        if(door== true)
        {
            lockPick.SetActive(true);
        }
    }
    public void Grab(Transform grabObjectPoint)
    {
        this.grabObjectPoint = grabObjectPoint;
    }
    public void setobjectgrabable(bool t)
    {
        IsGrabObject = t;
    }
    public bool getIsGrabObject()
    {
        return IsGrabObject;
    }
    private void FixedUpdate()
    {
        if (grabObjectPoint!=null)
        {
            this.gameObject.GetComponent<Rigidbody>().MovePosition(intera.getGrabLocal().position);
            this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        }
        /*if (Input.GetKeyDown(KeyCode.R))
        {
           this.grabObjectPoint= null;
            this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }*/
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            this.grabObjectPoint = null;
            this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        }
        if (Input.GetKey(KeyCode.F))
        {
            firstPersonCam.sensX = 0f;
            firstPersonCam.sensY = 0f;
            float xAxisRotation = Input.GetAxis("Mouse X") * rotationSensitivity;
            float yAxisRotation = Input.GetAxis("Mouse Y") * rotationSensitivity;
            this.transform.Rotate(Vector3.down, xAxisRotation);
            this.transform.Rotate(Vector3.right, yAxisRotation);

        }
        if (Input.GetKeyUp(KeyCode.F))
        {
            firstPersonCam.sensX = presensx;
            firstPersonCam.sensY = presensy;
          

        }

    }
}
