using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class feetcube : MonoBehaviour
{
    #region Variables
    public       bool         grounded;
    #endregion
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
