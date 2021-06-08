using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salchicha : MonoBehaviour
{
    public GameObject chichicha;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="box")
        {
            chichicha.SetActive(true);
        }
    }
}
