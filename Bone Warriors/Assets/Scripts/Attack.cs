using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator animator;

    public float attackDamage = 1;

    private bool notUsedYet = true;

    public Transform attackPointClose;


    public float attackRange = 0.5f;

    private Collider2D[] enemies;

    public LayerMask enemyLayers;

    private void Start()
    {
        animator.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        enemies = Physics2D.OverlapCircleAll(attackPointClose.position, attackRange, enemyLayers);

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

        animator.SetBool("Attack", true);
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
        if(attackPointClose == null)
        {
            return;
        }

        

        Gizmos.DrawSphere(attackPointClose.position, attackRange);

        
    }
}
