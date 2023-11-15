using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : MonoBehaviour
{
    Ray ray;
    [SerializeField] float range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Iinteractable iinteractable = GetInteractable();
        if (iinteractable!= null)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                iinteractable.Interact();
            }
        }
        
    }
    Iinteractable GetInteractable()
    {
        ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
       // RaycastHit hit;
        
        if (Physics.Raycast(ray, out RaycastHit hit, range))
        {
            
            if (hit.collider != null)
            {

                Iinteractable interactable = hit.collider.GetComponent<Iinteractable>();

               
                if (interactable != null)
                {
                    return interactable;
                }
            }
        }
        return null;
    }
}
