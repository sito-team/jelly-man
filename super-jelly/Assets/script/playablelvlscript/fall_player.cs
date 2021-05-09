using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall_player : MonoBehaviour
{
    private collectible_structure lifeless;
    private int substact_life=1;
    public GameObject spawnpoint;
    private void Start()
    {
        lifeless=GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();
    }
    private void OnCollisionEnter(Collision player_collision_verifict)
    {
        if (player_collision_verifict.collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            lifeless.takedamage(substact_life);
            player_collision_verifict.gameObject.transform.position = spawnpoint.transform.position;

        }
       
          
    }
}

