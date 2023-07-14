using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedCanvas : MonoBehaviour
{
    public Player player;
    public Text speedText;

    public float speed;

    void Start()
    {
        speed = player.moveSpeed;

        speedText.text = player.moveSpeed.ToString();

    }

    void Update()
    {
        if (player.moveSpeed != speed)
        {
            speed = player.moveSpeed;
            speedText.text = player.moveSpeed.ToString();
        }
    }
}
