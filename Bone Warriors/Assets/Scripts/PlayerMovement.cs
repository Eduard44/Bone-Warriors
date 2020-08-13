using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    public GameObject range;

    private Vector3 point;

    // Update is called once per frame
    void Update()
    {
        point = new Vector3(range.transform.position.x, 0, 0);
        if(gameObject.transform.position.x == point.x)
        {

        }
        else
        {
            Vector3 movement = new Vector3(movementSpeed, 0, 0);
            transform.position += movement * Time.deltaTime;
        }
    }
}
