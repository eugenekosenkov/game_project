using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class Heart : MonoBehaviour
{
    public Transform HealthPoint;
    public float HealthRange;

    public float ValueHealth;

    public LayerMask playerLayers;

    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Health();
        }
    }
    public void Health()
    {
        Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(HealthPoint.position, HealthRange, playerLayers);

        foreach (Collider2D player in hitPlayer)
        {
            player.GetComponent<Player>().TakeHealth(ValueHealth);
        }
        
        Destroy(gameObject);
    }

    void OnDrawGizmosSelected()
    {
        if (HealthPoint == null)
            return;

        Gizmos.DrawWireSphere(HealthPoint.position, HealthRange);
    }
}
