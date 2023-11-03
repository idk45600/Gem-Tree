using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lockPick : MonoBehaviour
{
    bool pickhit = false;
   // bool Backnfourth = false;
    [SerializeField] Transform start;
    [SerializeField] Transform end;
    [SerializeField] float SpeedOfBar=1.0f;
    private float startTime;
    private float Length;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }
   
   
    // Update is called once per frame
    void Update()
    {
        
        float backnfourth = Mathf.PingPong(Time.time * SpeedOfBar, 1);
        this.transform.position = Vector3.Lerp(start.position, end.position, backnfourth);

       
       

    }
}
