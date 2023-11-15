using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathManger : MonoBehaviour
{
    private PlayerStats playerStats;
    [SerializeField] GameObject DeathUi;
    private startMazePusher startMazePusher;
    private fireBehaviour fireBehaviour;
    [SerializeField] GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        playerStats = FindObjectOfType<PlayerStats>();
        startMazePusher = FindObjectOfType<startMazePusher>();
        fireBehaviour = FindObjectOfType<fireBehaviour>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerStats.getHealth() <= 0)
        {
            DeathUi.SetActive(true);
            Time.timeScale = 0;
            fireBehaviour.destroyFire();
            Player.transform.position = startMazePusher.getrespawnpoint().position;

        }
    }
}
