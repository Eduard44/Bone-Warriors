using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    ///public Animator animator;

    private bool notUsedYet = true;

    public Transform attackPoint;

    public float attackRange = 0.5f;

    public LayerMask enemyLayers;
    // Update is called once per frame
    void Update()
    {
        if (Physics2D.OverlapCircle(attackPoint.position, attackRange, enemyLayers) != null)
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
        Collider2D hitEnemy = Physics2D.OverlapCircle(attackPoint.position, attackRange, enemyLayers);
        if(hitEnemy != null)
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
