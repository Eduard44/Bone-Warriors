using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "AttackPointFar")
        {
            Debug.Log("FIRE FIRE FIRE");
            InvokeRepeating("Fire", 0f, 2f);
        }
    }
    public void Fire()
    {
        Instantiate(bullet, gameObject.transform.position, gameObject.transform.rotation);
    }
}
