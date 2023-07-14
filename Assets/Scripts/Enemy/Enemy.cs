using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public ExperienceManager expManager;

    public float maxHealth;
    private float currentHealth;
    public float damage;
    public float speed;
    public float distationPlayer;

    public float EXP;

    public Image bar;

    //public Animator animator;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        bar.fillAmount = currentHealth/maxHealth;
        if (currentHealth <= 0)
        {
            Die();

        }
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
    }

    public void Die()
    {
        Debug.Log("Enemy died!");

        //animator.SetTrigger("attack");

        Destroy(gameObject);

        ExperienceManager.setExp(EXP);

        ExperienceManager.setKills(1);
    }

}
