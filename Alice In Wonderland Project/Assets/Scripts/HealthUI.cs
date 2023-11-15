using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class HealthUI : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    PlayerStats PlayerStats;
    // Start is called before the first frame update
    void Start()
    {
        PlayerStats = FindObjectOfType<PlayerStats>();
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + PlayerStats.getHealth();
    }
}
