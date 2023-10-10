using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactor : MonoBehaviour
{
    Ray ray;
    [SerializeField] Transform source;
    [SerializeField] float range;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public Transform getGrabLocal()
    {
        return source;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(ray, out RaycastHit hitData, range))
            {
             //   Debug.Log("hit");
               // Debug.DrawRay(ray.origin, ray.direction);
                if (hitData.collider.gameObject.GetComponent<Interactable>()!=null)
                {
                    if (hitData.collider.gameObject.GetComponent<Interactable>().getIsGrabObject()==true)
                    {
                        hitData.collider.gameObject.GetComponent<Interactable>().Grab(source);
                    }
                    else
                    {
                        hitData.collider.gameObject.GetComponent<Interactable>().Interact();
                    }
                   

                }

            }
        }
       
    }
}
/*Debug.DrawRay(ray.origin, ray.direction);
Physics.Raycast(ray, out RaycastHit hitData, range);
if (hitData.transform.gameObject.GetComponent<Interactable>() != null)
{
    go.SetActive(true);
}*/