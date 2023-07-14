using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillsCanvas : MonoBehaviour
{
    public Player player;
    public Text currentKills;
    public Text MaxKills;

    public int CurrentKillsInt;
    public int MaxKillsInt;

    void Start()
    {
        CurrentKillsInt = player.currentKills;

        MaxKillsInt = player.maxKills;

        currentKills.text = player.currentKills.ToString();

        MaxKills.text = player.maxKills.ToString();
    }

    void Update()
    {
        if (player.currentKills != CurrentKillsInt)
        {
            CurrentKillsInt = player.currentKills;
            currentKills.text = player.currentKills.ToString();
        }
        if (player.maxKills > MaxKillsInt)
        {
            MaxKillsInt = player.maxKills;
            MaxKills.text = player.maxKills.ToString();
        }
    }

}
