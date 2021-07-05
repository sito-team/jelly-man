using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class enemy_patrol : MonoBehaviour
{
     #region Variables
    public          float           speed       =  2.0f;
    public          Transform       target;
    #endregion
    void Start()
    {
        transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="waypoint")
        {
                target = other.gameObject.GetComponent<enemy_waypoint>().nextpoint;
                transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
        }
    }
}
