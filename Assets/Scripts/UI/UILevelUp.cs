using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UILevelUp : MonoBehaviour
{
    public GameObject lvlupUI;

    private bool health;
    private bool energy;
    private bool damage;
    private bool speed;

    private void Start()
    {
        health = false;
        energy= false;
        damage= false;
        speed= false;
    }

    public void ActivelvlUI()
    {
        lvlupUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void CloselvlUI()
    {
        lvlupUI.SetActive(false);
        Time.timeScale = 1f;
    }

    public bool getbuttonHealth()
    {
        return health;
    }
    public void setbuttonHealth(bool check)
    {
        health = check;
    }

    public bool getbuttonEnergy()
    {
        return energy;
    }
    public void setbuttonEnergy(bool check)
    {
        energy = check;
    }

    public bool getbuttonDamage()
    {
        return damage;
    }
    public void setbuttonDamage(bool check)
    {
        damage = check;
    }

    public bool getbuttonSpeed()
    {
        return speed;
    }
    public void setbuttonSpeed(bool check)
    {
        speed = check;
    }
}
