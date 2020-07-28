using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;

    public Transform attackPoint;

    public float attackRange = 0.5f;

    public LayerMask enemyLayers;
    // Update is called once per frame
    void Update()
    {
        AttackAction();
    }

    void AttackAction()
    {
        //animator.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

        foreach (var enemy in hitEnemies)
        {
            Debug.Log("I Hit");
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
