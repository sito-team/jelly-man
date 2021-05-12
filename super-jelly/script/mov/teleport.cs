using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject spawnpoint;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision player_collision_verifict)
    {
        if (player_collision_verifict.collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {

            player_collision_verifict.gameObject.transform.position = spawnpoint.transform.position;
           


        }
    }
}
