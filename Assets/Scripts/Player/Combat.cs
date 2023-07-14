using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Combat : MonoBehaviour
{
    public Player player;

    public Animator animator;

    public Transform attackPoint;
    public float attackRange = 0.5f;

    public LayerMask enemyLayers;

    void Update()
    {
        if (player.currentEnergy >= player.maxEnergy)
        {
            if (Input.GetKeyUp("space"))
                Attack();
        }
    }

    void Attack()
    {
        animator.SetTrigger("attack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(player.damage);
        }
        player.currentEnergy =0;
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;
       
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}

