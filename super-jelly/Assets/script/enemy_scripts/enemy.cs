using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float closeDistance = 5;
    [SerializeField]
   
    private collectible_structure lifeless;
    private GameObject si;
    private void Start()
    {
        
        lifeless = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();

    }


    // Start is called before the first frame update
    private void OnCollisionEnter(Collision player_collision_verifict)
    {
        if (player_collision_verifict.collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            


            player_collision_verifict.gameObject.transform.position = FindClosestEnemy().transform.position;
            
            lifeless.takedamage(1);


        }
    }

    
    
    GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Respawn");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }


}

