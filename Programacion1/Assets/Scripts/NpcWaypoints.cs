using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcWaypoints : MonoBehaviour
{
    public List<Transform> waypoints;
    public float speed;

    public bool backtrace;

    int _currentWaypoint = 0;
    int _indexModifier = 1;
    private bool _goalReached = false;

    void Start()
    {
        
    }
    
    void Update()
    {
            Advance();
    }
    
    public void Advance()
    {
        if (Vector3.Distance(waypoints[_currentWaypoint].position, transform.position) < 0.5f)
        {
            if(_currentWaypoint+_indexModifier >= waypoints.Count || _currentWaypoint+_indexModifier<0)
            {
                if (backtrace)
                {
                    _indexModifier *= -1;
                }
                else
                {
                    _goalReached = true;
                }
            }
            
            if(!_goalReached) _currentWaypoint += _indexModifier;
        }

        if(!_goalReached)
        {
            Vector3 dir = waypoints[_currentWaypoint].position - transform.position;
            transform.up = dir;
            transform.position += transform.up * speed * Time.deltaTime;
        }
    }

    

    private void OnDrawGizmos()
    {
        if(waypoints.Count > 0)
        {
            for (int i = 0; i < waypoints.Count; i++)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawSphere(waypoints[i].position, .3f);

                if((i + 1) < waypoints.Count)
                {
                    Gizmos.color = Color.green;
                    Gizmos.DrawLine(waypoints[i].position, waypoints[i + 1].position);
                }
            }
        }
    }
}
