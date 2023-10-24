using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiHandler : MonoBehaviour
{
    [SerializeField]GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void continueButton()
    {
        panel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space))
        {
            panel.SetActive(false);
        }   
    }
}
