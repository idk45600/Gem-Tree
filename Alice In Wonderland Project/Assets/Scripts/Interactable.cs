using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] bool IsEndObject= true;
    [SerializeField] bool IsChessObject = false;
    [SerializeField] bool IsGrabObject = false;
    [SerializeField] bool IsPill1 = false;
    [SerializeField] bool IsPill2 = false;
    [SerializeField] bool IsPill3 = false;
    Transform grabObjectPoint;
    SceneChanger SceneChanger;
    Vector3 moveDirection;
    PlayerMovement plamove;
    interactor intera;
    //firstPersonCam cam;
    // Start is called before the first frame update
    void Start()
    {
        //  cam = FindFirstObjectByType<firstPersonCam>();
        SceneChanger = FindObjectOfType<SceneChanger>();
        plamove = FindObjectOfType<PlayerMovement>();
        intera = FindObjectOfType<interactor>();
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
    }
}
