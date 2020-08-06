using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(movementSpeed, 0, 0);
        transform.position += movement * Time.deltaTime;
    }
}
