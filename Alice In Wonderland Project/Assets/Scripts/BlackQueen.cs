using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackQueen : MonoBehaviour,Iinteractable
{
   
    Transform grabObjectPoint;
    [SerializeField] Transform pointToGoto;
    PlayerMovement plamove;
 
    public void Interact()
    {
        grabObjectPoint = pointToGoto;
        plamove.Reversecontrols(true);

    }

    // Start is called before the first frame update
    void Start()
    {
        plamove = FindObjectOfType<PlayerMovement>();
    }
    private void FixedUpdate()
    {
        if (grabObjectPoint != null)
        {
            this.gameObject.GetComponent<Rigidbody>().MovePosition(grabObjectPoint.position);
            this.gameObject.GetComponent<Rigidbody>().useGravity = false;
            this.gameObject.GetComponent<Rigidbody>().freezeRotation = true;
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
                this.gameObject.GetComponent<Rigidbody>().freezeRotation = false;
                plamove.Reversecontrols(false);
               
            }
           
        }
    }
}
