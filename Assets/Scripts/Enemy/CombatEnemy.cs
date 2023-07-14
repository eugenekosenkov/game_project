using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatEnemy : MonoBehaviour
{
    public Enemy enemy;

    public Animator animator;

    public Transform attackPoint;
    public float attackRange;

    public float energy;
    public float maxenergy;

    public LayerMask playerLayers;

    void Start()
    {
        energy = 0;
    }

    void Update()
    {
        energy += Time.deltaTime;

    }

    public void OnTriggerStay2D(Collider2D other)
    {
        if (energy >= maxenergy)
        {
            if (other.CompareTag("Player"))
            {
                Attack();
                energy= 0;
            }
        }
        
    }

    public void Attack()
    {
        animator.SetTrigger("attack");

        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, playerLayers);

        foreach (Collider2D player in hitPlayer)
        {
            player.GetComponent<Player>().TakeDamage(enemy.damage);
        }

    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
            return;

        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}