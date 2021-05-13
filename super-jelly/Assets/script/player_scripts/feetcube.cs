using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feetcube : MonoBehaviour
{
    public bool grounded;

    void OnTriggerEnter()
    {

        grounded = true;
       
    }

    void OnTriggerStay()
    {
        grounded = true;
       
    }

    void OnTriggerExit()
    {
       
            grounded = false;
        
    }
}
