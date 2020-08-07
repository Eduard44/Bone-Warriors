using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float HealthPoints;
    void Start()
    {

    }

    void Update()
    {
        if(this.HealthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    void TakeDamage(int damage)
    {
        this.HealthPoints -= damage;
    }
}
