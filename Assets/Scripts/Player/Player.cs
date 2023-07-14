using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    ExperienceManager expManager;

    public UILevelUp levelUpUI;

    public float maxHealth;

    public float currentHealth;

    public float moveSpeed;

    public float damage;

    public float currentExp;

    public float maxExp;

    public int currentLevel;

    public double currentEnergy;
    public double maxEnergy;

    public int currentKills;
    public int maxKills;

    void Start()
    {
        maxHealth=100;
        currentHealth=maxHealth;
        moveSpeed = 3;
        damage = 20;
        currentExp = 0;
        maxExp = 100;
        currentLevel =1;
        currentEnergy = 0;
        maxEnergy = 1.5;
        currentKills = 0;
        maxKills = 29;
    }

    void Update()
    {
        if (currentEnergy < maxEnergy)
        {
            currentEnergy += Time.deltaTime;
        }

        if (ExperienceManager.getEXP()>0)
        {
            ExpChange(ExperienceManager.getEXP());
            ExperienceManager.setExp(0);
        }

        if (ExperienceManager.getKills() > 0)
        {
            currentKills++;
            ExperienceManager.setKills(0);
        }

        if (currentKills >= maxKills)
        {
            SceneManager.LoadScene(3);
        }

        if (levelUpUI.getbuttonHealth())
        {
            maxHealth += 30;
            currentHealth = maxHealth;
            levelUpUI.setbuttonHealth(false);
            levelUpUI.CloselvlUI();
        }
        else if (levelUpUI.getbuttonEnergy())
        {
            if ((maxEnergy - 0.25) > 0)
            {
                currentHealth = maxHealth;
                maxEnergy = maxEnergy - 0.25;
                levelUpUI.setbuttonEnergy(false);
                levelUpUI.CloselvlUI();
            }
            else
            {
                currentHealth = maxHealth;
                levelUpUI.setbuttonEnergy(false);
                levelUpUI.CloselvlUI();
            }
        }
        else if (levelUpUI.getbuttonDamage())
        {
            currentHealth = maxHealth;
            damage += 20;
            levelUpUI.setbuttonDamage(false);
            levelUpUI.CloselvlUI();
        }
        else if (levelUpUI.getbuttonSpeed())
        {
            currentHealth = maxHealth;
            moveSpeed += 1;
            levelUpUI.setbuttonSpeed(false);
            levelUpUI.CloselvlUI();
        }

    }

    private void ExpChange(float NewExp)
    {
        currentExp += NewExp;
        if(currentExp>= maxExp)
        {
            LevelUp();
        }
    }

    private void LevelUp()
    {   
        levelUpUI.ActivelvlUI();

        currentExp = currentExp- maxExp;

        maxExp += 25;

        currentLevel++;

    }

    public void TakeHealth(float health)
    {
        if(currentHealth+health>=maxHealth) 
            currentHealth = maxHealth;
        else 
            currentHealth += health;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();

        }
    }

    public void Die()
    {
        Debug.Log("you're dead!");

        SceneManager.LoadScene(2);
    }

}
