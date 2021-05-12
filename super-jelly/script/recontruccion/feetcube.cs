using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feetcube : MonoBehaviour
{
    public bool grounded;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "wind")
        {
            grounded = true;
        }
    }


    void OnTriggerStay(Collider other)
    {
        if (other.tag != "wind")
        {
            grounded = true;
        }

    }

    void OnTriggerExit(Collider other)
    {

        grounded = false;


    }
}
