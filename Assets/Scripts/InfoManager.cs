using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InfoManager : MonoBehaviour
{
    public TextMeshProUGUI KillText;
    public TextMeshProUGUI HealthText;
    public VictoryDefeatManager victoryDefeatManager;
    public PlayerData playerdata;
    public int playerStartHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerdata.Kills = 0;
        playerdata.health = playerStartHealth;
    }

    // Update is called once per frame
    void Update()
    {
        KillText.text = "KILLS: " + playerdata.Kills + "/" + victoryDefeatManager.killRequirement;
        HealthText.text = "HEALTH POINTS: " + playerdata.health;

    }
}
