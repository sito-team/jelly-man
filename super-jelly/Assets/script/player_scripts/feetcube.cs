using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feetcube : MonoBehaviour
{
    public bool grounded;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("floor"))
        grounded = true;
       
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("floor"))
            grounded = true;
       
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("floor"))
            grounded = false;
        
    }
}
