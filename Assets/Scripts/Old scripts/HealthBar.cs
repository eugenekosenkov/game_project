using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Player player;

    public Image bar;

    public float fill;

    public float maxHP;

    void Start()
    {
        maxHP= player.maxHealth;

        fill = player.maxHealth;
    }

    void Update()
    {
        bar.fillAmount= player.currentHealth/fill;

        if(player.maxHealth > maxHP)
        {
            maxHP = player.maxHealth;

            fill = player.maxHealth;
        }
    }
}
