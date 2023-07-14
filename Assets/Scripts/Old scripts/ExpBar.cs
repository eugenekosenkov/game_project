using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExpBar : MonoBehaviour
{
    public Player player;

    public Image bar;

    public float fill;
    public float maxExp;

    void Start()
    {
        fill = player.currentExp;
        maxExp = player.maxExp;
        bar.fillAmount = 0;
    }

    void Update()
    {
        if (player.currentExp > fill)
        {
            fill = player.currentExp;
            bar.fillAmount += fill;
        }
        if (bar.fillAmount>= maxExp && player.maxExp>= maxExp)
        {
            bar.fillAmount = 0;
            fill = player.currentExp;
            maxExp = player.maxExp;
        }
    }
}
