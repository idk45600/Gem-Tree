using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour,Iinteractable
{
    [SerializeField] GameObject LockPickOnThisDoor;

    public void Interact()
    {
        if (LockPickOnThisDoor != null)
        {
            LockPickOnThisDoor.SetActive(true);
        }
        else
        {
            this.transform.Rotate(0, 90, 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
