using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuegoCOsas : MonoBehaviour
{
    public GameObject enemy;
    public enemy enemyScrip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            enemyScrip.damage_kind(true, other.gameObject);
            
        }
    }
}
