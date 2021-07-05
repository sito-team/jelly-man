using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//TP2 - * facundo olmedo *.
public class enemy_follow_player : MonoBehaviour
{
    
    #region Variables     
    public          NavMeshAgent        agent;
    public          Animator            spider;
                    Vector3             destination;
    private         bool                playerOnSight;

    #endregion


    private void Awake()
    {
        
        agent = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            destination = other.transform.position;

            playerOnSight = true;


        }

    }
    private void OnTriggerStay(Collider other)
    { 

        if (other.tag == "Player")
        {
            destination = other.transform.position;

            playerOnSight = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            playerOnSight = false;
            agent.isStopped = true;
            transform.LookAt(null);
        }
    }
    private void Update()
    {
        //Check for sight and attack range
        
        
        if (playerOnSight)
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
        transform.LookAt(new Vector3(destination.x, transform.position.y , destination.z));
    }
}
