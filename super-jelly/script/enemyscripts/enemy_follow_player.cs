using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemy_follow_player : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent agent;
    public Animator spider;
    public Transform player;

    //States
    public float sightRange;
    public bool playerInSightRange;
    public changecaracter camara_changecaracte;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        

    }

    private void Update()
    {
        player = camara_changecaracte.player_form.transform;
        //Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(player.transform.position, sightRange );
        
        if (playerInSightRange)
        { 
            ChasePlayer();

        }
            if(playerInSightRange==false)
        { 
            spider.SetBool("walk", false);
        }

    }


    private void ChasePlayer()
    {
        spider.SetBool("walk",true);
        agent.SetDestination(player.position);
        transform.LookAt(player.transform);
    }
}
