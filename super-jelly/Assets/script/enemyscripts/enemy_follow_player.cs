using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemy_follow_player : MonoBehaviour
{
    // Start is called before the first frame update

    public NavMeshAgent agent;
    public Animator spider;
    Vector3 destination;
    private bool player_is_on;

    //States
    public float sightRange;
    public bool playerInSightRange;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            destination = other.transform.position;

            player_is_on = true;


        }

    }
    private void OnTriggerStay(Collider other)
    { 

        if (other.tag == "Player")
        {
            destination = other.transform.position;

            player_is_on = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            player_is_on = false;
            agent.isStopped = true;
            transform.LookAt(null);
        }
    }
    private void Update()
    {
        //Check for sight and attack range
        
        
        if (player_is_on)
        {
            
            agent.ResetPath();
            ChasePlayer();

        }
        else
        { 
            spider.SetBool("walk", false);
        }

    }


    private void ChasePlayer()
    {
        spider.SetBool("walk",true);
        agent.SetDestination(destination);
        transform.LookAt(destination);
    }
}
