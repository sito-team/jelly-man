using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    public bool wind_on_si;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            wind_on_si = true;


        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            wind_on_si = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        wind_on_si = false;
    }
}
