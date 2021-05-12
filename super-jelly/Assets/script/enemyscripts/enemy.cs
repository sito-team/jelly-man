using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float closeDistance = 5;
    [SerializeField]
    private GameObject spawnpoint;
    private collectible_structure lifeless;
    private void Start()
    {
        lifeless = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();

    }


    // Start is called before the first frame update
    private void OnCollisionEnter(Collision player_collision_verifict)
    {
        if (player_collision_verifict.collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            
            player_collision_verifict.gameObject.transform.position = spawnpoint.transform.position;
            lifeless.takedamage(1);


        }
    }

}

