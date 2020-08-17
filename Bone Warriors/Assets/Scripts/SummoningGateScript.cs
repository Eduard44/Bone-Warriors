using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummoningGateScript : MonoBehaviour
{
    public Transform meleeUnitPrefab;
    public Vector3 position;

    public void SummonMeleeUnit()
    {
        Instantiate(meleeUnitPrefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}
