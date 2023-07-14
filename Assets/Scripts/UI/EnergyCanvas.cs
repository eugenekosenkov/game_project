using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyCanvas : MonoBehaviour
{
    public Player player;
    public Text currentEnergy;
    public Text MaxEnergy;

    public double CurrentEnergyInt;
    public double MaxEnergyInt;

    void Start()
    {
        CurrentEnergyInt = player.currentEnergy;

        MaxEnergyInt = player.maxEnergy;

        currentEnergy.text = player.currentEnergy.ToString();

        MaxEnergy.text = player.maxEnergy.ToString();
    }

    void Update()
    {
        if (player.currentEnergy != CurrentEnergyInt)
        {
            CurrentEnergyInt = player.currentEnergy;
            currentEnergy.text = player.currentEnergy.ToString();
        }
        if (player.maxEnergy != MaxEnergyInt)
        {
            MaxEnergyInt = player.maxEnergy;
            MaxEnergy.text = player.maxEnergy.ToString();
        }
    }

}
