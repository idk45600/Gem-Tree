using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keydoor : MonoBehaviour
{
    [SerializeField] Transform keyhole1;
    [SerializeField] Transform keyhole2;
    [SerializeField] Transform keyhole3;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Key")
        {
            collision.gameObject.GetComponent<Key>().Setkeypos(keyhole1);
        }
        if (collision.gameObject.name == "Key (1)")
        {
            collision.gameObject.GetComponent<Key>().Setkeypos(keyhole2);
        }
        if (collision.gameObject.name == "Key (2)")
        {
            collision.gameObject.GetComponent<Key>().Setkeypos(keyhole3);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
