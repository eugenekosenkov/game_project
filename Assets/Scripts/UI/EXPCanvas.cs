using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class EXPCanvas : MonoBehaviour
{
    public Player player;
    public Text CurrentEXP;
    public Text MaxEXP;

    public float CurrentEXPInt;
    public float MaxEXPInt;


    void Start()
    {
        CurrentEXPInt = player.currentExp;

        MaxEXPInt = player.maxExp;

        CurrentEXP.text = player.currentExp.ToString();

        MaxEXP.text = player.maxExp.ToString();
    }

    void Update()
    {
        if (player.currentExp > CurrentEXPInt)
        {
            CurrentEXPInt = player.currentExp;
            CurrentEXP.text = player.currentExp.ToString();
        }
        if (player.maxExp >= MaxEXPInt)
        {
            CurrentEXPInt = player.currentExp;
            CurrentEXP.text = player.currentExp.ToString();
            MaxEXPInt = player.maxExp;
            MaxEXP.text = player.maxExp.ToString();
        }
    }
}
