using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startMazePusher : MonoBehaviour
{
    [SerializeField] GameObject fire;
    [SerializeField] GameObject healthUI;
    [SerializeField] Transform respawnPoint;
    private BlackPressurePlate bp;
    private WhitePressurePlate wp;
    bool fireNotActive=true;


    // Start is called before the first frame update
    void Start()
    {
        bp = FindObjectOfType<BlackPressurePlate>();
        wp = FindObjectOfType<WhitePressurePlate>();
    }
    public void startpressuremach()
    {
        fireNotActive = false;
        Instantiate(fire);
        //healthUI.SetActive(true);
      
    }
    public Transform getrespawnpoint()
    {
        return respawnPoint;
    }
    
    // Update is called once per frame
    void Update()
    {

        if (bp.getIsBlackQueenOnPlate() == true && wp.getIsWhiteQueenOnPlate() == true && fireNotActive == true)
        {

            startpressuremach();
            
        }
    }
}
