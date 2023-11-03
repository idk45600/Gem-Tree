using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPickInputManger : MonoBehaviour
{
    [SerializeField] BoxCollider2D overlap;
    [SerializeField] GameObject door;
    [SerializeField] GameObject lockpick;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator waiter()
    {
        yield return new WaitForSecondsRealtime(3);
    
        if (this.GetComponent<BoxCollider2D>().IsTouching(overlap))
        {

            door.transform.Rotate(0, 90, 0);
           lockpick.SetActive(false);
            Time.timeScale = 1;

        }
        else
        {
            Time.timeScale = 1;

        }
       // yield return new WaitForSeconds(3);
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 0;
            StartCoroutine( waiter());
            
        }
    }
}
