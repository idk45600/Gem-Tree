using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] bool IsEndObject= true;
    [SerializeField] bool IsChessObject = false;
    SceneChanger SceneChanger;
    Vector3 moveDirection;
    PlayerMovement plamove;
    //firstPersonCam cam;
    // Start is called before the first frame update
    void Start()
    {
        //  cam = FindFirstObjectByType<firstPersonCam>();
        SceneChanger = FindObjectOfType<SceneChanger>();
        plamove = FindObjectOfType<PlayerMovement>();
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
            this.gameObject.GetComponent<Rigidbody>().AddForce(moveDirection.normalized * 50f * 10f, ForceMode.Force);
        }
    }
    // Update is called once per frame
    void Update()
    {
      //  if (cam.getHitData().transform.gameObject == this && IsEndObject==true && Input.GetKeyDown(KeyCode.E))
        //{
          //   SceneChanger.loadNewScene();
        //}
    }
}
