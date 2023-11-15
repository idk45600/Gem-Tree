using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPressurePlate : MonoBehaviour
{
    private bool blackQueenOnPlate=false;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BlackQueen")
        {
            blackQueenOnPlate = true;
        }
    }
    public bool getIsBlackQueenOnPlate()
    {
        return blackQueenOnPlate;
    }
}
