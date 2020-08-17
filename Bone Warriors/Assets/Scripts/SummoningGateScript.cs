using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummoningGateScript : MonoBehaviour
{
    public Transform spawnPoint;
    public Transform meleeUnitPrefab;

    public void SummonMeleeUnit()
    {
        Instantiate(meleeUnitPrefab, spawnPoint);
    }
}
