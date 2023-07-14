using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageCanvas : MonoBehaviour
{
    public Player player;
    public Text damageText;

    public double damage;

    void Start()
    {
        damage = player.damage;

        damageText.text = player.damage.ToString();

    }

    void Update()
    {
        if (player.damage != damage)
        {
            damage = player.damage;
            damageText.text = player.damage.ToString();
        }
    }
}
