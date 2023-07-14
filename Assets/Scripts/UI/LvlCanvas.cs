using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class LvlCanvas : MonoBehaviour
{
    public Player player;
    public Text lvl;

    public int lvlInt;

    void Start()
    {
        lvlInt = player.currentLevel;

        lvl.text = player.currentLevel.ToString();
    }

    void Update()
    {
        if (player.currentLevel > lvlInt)
        {
            lvlInt = player.currentLevel;
            lvl.text = player.currentLevel.ToString();
        }
    }
}
