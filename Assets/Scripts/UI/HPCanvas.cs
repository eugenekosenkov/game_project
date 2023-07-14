using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class HPCanvas : MonoBehaviour
{
    public Player player;
    public Text CurrentHP;
    public Text MaxHP;

    public float CurrentHPInt;
    public float MaxHPInt;

    void Start()
    {
        CurrentHPInt = player.currentHealth;

        MaxHPInt=player.maxHealth;

        CurrentHP.text = player.currentHealth.ToString();

        MaxHP.text = player.maxHealth.ToString();
    }

    void Update()
    {
        if (player.currentHealth != CurrentHPInt)
        {
            CurrentHPInt = player.currentHealth;
            CurrentHP.text = player.currentHealth.ToString();
        }
        if(player.maxHealth > MaxHPInt)
        {
            MaxHPInt = player.maxHealth;
            MaxHP.text = player.maxHealth.ToString();
        }
    }
}
