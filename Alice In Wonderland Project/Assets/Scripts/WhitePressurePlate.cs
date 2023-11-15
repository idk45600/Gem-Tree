using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePressurePlate : MonoBehaviour
{
    private bool WhiteQueenOnPlate = false;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "WhiteQueen")
        {
            WhiteQueenOnPlate = true;
        }
    }
    public bool getIsWhiteQueenOnPlate()
    {
        return WhiteQueenOnPlate;
    }
}
