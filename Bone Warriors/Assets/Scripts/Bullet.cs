using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float bulletDamage = 1f;
    public Rigidbody2D rb;
    void Start()
    {
        rb.velocity = transform.right * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.name == "Spartan Boss")
        {
            Debug.Log(collision.name + "WE HIT SOMETHING WITH THE BULLET!");
            collision.GetComponent<Health>().healthPoints -= bulletDamage;
            Destroy(gameObject);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
