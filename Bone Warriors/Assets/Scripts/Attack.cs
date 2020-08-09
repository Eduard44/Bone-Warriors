﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    ///public Animator animator;

    public float attackDamage = 1;

    private bool notUsedYet = true;

    public Transform attackPoint;

    public float attackRange = 0.5f;

    private Collider2D[] enemies;

    public LayerMask enemyLayers;
    // Update is called once per frame
    void Update()
    {

        enemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        if (enemies != null)
        {
            if (notUsedYet)
            {
                InvokeRepeating("AttackAction", 0, 2f);
            }
        }
        
    }

    void AttackAction()
    {
        notUsedYet = false;

        //animator.SetTrigger("Attack");
        //Collider2D hitEnemy = Physics2D.OverlapCircle(attackPoint.position, attackRange, enemyLayers);
        foreach (var enemy in enemies)
        {
            if (enemy != null)
            {
                enemy.GetComponent<Health>().HealthPoints -= attackDamage;
                Debug.Log($"ATTACKER:{gameObject.name}  + TARGET HIT:{enemy.name}");
            }
        }
        

    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }

        Gizmos.DrawSphere(attackPoint.position, attackRange);
    }
}