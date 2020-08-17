using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float healthPoints;

    public float maxHealth;

    void Start()
    {
        healthPoints = maxHealth;
    }

    void Update()
    {
        if(this.healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        this.healthPoints -= damage;
    }
}
