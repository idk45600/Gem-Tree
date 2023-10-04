using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] bool IsEndObject= true;
    SceneChanger SceneChanger;

    //firstPersonCam cam;
    // Start is called before the first frame update
    void Start()
    {
        //  cam = FindFirstObjectByType<firstPersonCam>();
        SceneChanger = FindObjectOfType<SceneChanger>();
    }
    public void Interact()
    {
        if (IsEndObject==true)
        {
            SceneChanger.loadNewScene();
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
