using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraMovement = new Vector3(Input.GetAxis("Horizontal"),0,0);
        transform.position += cameraMovement * Time.deltaTime * cameraSpeed;
    }
}
