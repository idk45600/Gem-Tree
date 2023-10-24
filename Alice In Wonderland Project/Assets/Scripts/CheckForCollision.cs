using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForCollision : MonoBehaviour
{
    int wincondicount = 0;
    [SerializeField] int winCondiMax = 2;
    SceneChanger sceneChanger;

    //float times = 0;
    // Start is called before the first frame update
    void Start()
    {
        sceneChanger = FindObjectOfType<SceneChanger>();
        
    }

   
    private void OnCollisionEnter(Collision collision)
    {
       // times += Time.deltaTime;
        if (collision.gameObject.tag=="WinCondition" )
        {
            
            wincondicount++;
            collision.gameObject.GetComponent<Interactable>().setobjectgrabable(false);
            collision.gameObject.GetComponent<Interactable>().Grab(null);
            collision.gameObject.GetComponent<Rigidbody>().useGravity = true;

        }
    }
    // Update is called once per frame
    void Update()
    {
        if (wincondicount== winCondiMax)
        {
         
            sceneChanger.loadNewScene();
        }
    }
}
