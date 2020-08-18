using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public Animator animator;

    public float attackDamage = 1;

    private bool notUsedYet = true;

    private bool notUsedYetFar = true;

    public Transform attackPoint;

    public Transform attackPointFar;

    public float attackRange = 0.5f;

    public float attackRangeFar = 0.5f;

    private Collider2D[] enemies;

    private Collider2D[] enemiesFar;

    public LayerMask enemyLayers;

    public LayerMask enemyLayersFar;
    // Update is called once per frame
    void Update()
    {

        enemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        enemiesFar = Physics2D.OverlapCircleAll(attackPointFar.position, attackRangeFar, enemyLayersFar);

        if (enemies != null)
        {
            if (notUsedYet)
            {
                InvokeRepeating("AttackAction", 0, 2f);
            }
        }
        else
        {
            notUsedYet = true;
        }

        if(enemiesFar != null)
        {
            if (notUsedYetFar)
            {
                InvokeRepeating("AttackActionFar", 0, 2f);
            }
        }else
        {
            notUsedYetFar = true;
        }

    }

    void AttackAction()
    {
        notUsedYet = false;

        //Collider2D hitEnemy = Physics2D.OverlapCircle(attackPoint.position, attackRange, enemyLayers);
        foreach (var enemy in enemies)
        {
            
            if (enemy != null)
            {
                enemy.GetComponent<Health>().healthPoints -= attackDamage;
                Debug.Log($"ATTACKER:{gameObject.name}  + TARGET HIT:{enemy.name}");
            }
        }
    }
    
    void AttackActionFar()
    {
        notUsedYetFar = false;

        //Collider2D hitEnemy = Physics2D.OverlapCircle(attackPoint.position, attackRange, enemyLayers);
        foreach (var enemy in enemiesFar)
        {
            animator.SetBool("IsAttacking", true);
            if (enemy != null)
            {
                enemy.GetComponent<Health>().healthPoints -= attackDamage;
                Debug.Log($"ATTACKER FAR:{gameObject.name}  + TARGET HIT FAR:{enemy.name}");
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        if (attackPointFar == null)
        {
            return;
        }

        Gizmos.DrawSphere(attackPoint.position, attackRange);

        Gizmos.DrawSphere(attackPointFar.position, attackRangeFar);
    }
}
