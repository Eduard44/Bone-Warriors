using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void Start()
    {
            
    }

    private void Update()
    {
            
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Spartan Boss"){
            Debug.Log("Movement Stopped");
            var script = gameObject.GetComponentInParent<PlayerMovement>();
            script.movementSpeed = 0;
            Animator animator= gameObject.GetComponentInParent<Animator>();
            animator.SetBool("Attack", true);
        }
    }

}
