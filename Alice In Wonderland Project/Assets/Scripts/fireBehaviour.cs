using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBehaviour : MonoBehaviour
{
     Transform start;
    Transform end;
    [SerializeField] float Speed = 1.0f;
    private float startTime;
    private float Length;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        Length = Vector3.Distance(start.position, end.position);
        
    }
    private void Awake()
    {
        start = GameObject.Find("fireStart").transform;
        end = GameObject.Find("fireEnd").transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name== "player")
        {
            other.GetComponent<PlayerStats>().DamagePlayer(other.GetComponent<PlayerStats>().getHealth());
        }
    }

    public void destroyFire()
    {
        Destroy(this);
    }
    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * Speed;
        float fractionOfJourney = distCovered / Length;

        this.transform.position = Vector3.Lerp(start.position, end.position,fractionOfJourney);
    }
}
