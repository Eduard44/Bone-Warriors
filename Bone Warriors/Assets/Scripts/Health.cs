using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float healthPoints;

    void Update()
    {
        if(this.healthPoints <= 0)
        {
            Destroy(gameObject);
        }
    }

}
