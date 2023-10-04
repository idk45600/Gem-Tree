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

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            if (Physics.Raycast(ray, out RaycastHit hitData, range))
            {
                if (hitData.collider.gameObject.GetComponent<Interactable>()!=null)
                {
                    hitData.collider.gameObject.GetComponent<Interactable>().Interact();
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