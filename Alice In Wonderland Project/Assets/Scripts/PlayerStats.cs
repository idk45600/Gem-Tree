using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void DamagePlayer(int dmg)
    {
        health -= dmg;
    }
    public int getHealth()
    {
        return health;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
