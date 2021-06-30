using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlertFire : MonoBehaviour
{
    
    Vector3 destination;

    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")
        {
            destination = other.transform.position;
           
        }
        transform.LookAt(destination);
    }
}
