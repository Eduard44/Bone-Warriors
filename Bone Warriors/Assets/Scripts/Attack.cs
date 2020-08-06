using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    ///public Animator animator;

    private bool notUsedYet = true;

    public Transform attackPoint;

    public float attackRange = 0.5f;

    private Collider2D enemy;

    public LayerMask enemyLayers;
    // Update is called once per frame
    void Update()
    {

        enemy = Physics2D.OverlapCircle(attackPoint.position, attackRange, enemyLayers);

        if (enemy != null)
        {
            if (notUsedYet)
            {
                InvokeRepeating("AttackAction", 0, 2f);
            }
        }
        
    }

    void AttackAction()
    {
        //animator.SetTrigger("Attack");
        //Collider2D hitEnemy = Physics2D.OverlapCircle(attackPoint.position, attackRange, enemyLayers);
        if(enemy != null)
        {
            Debug.Log("Hit");
        }

        notUsedYet = false;
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
