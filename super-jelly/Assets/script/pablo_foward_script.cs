using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pablo_foward_script : MonoBehaviour
{
    public float push;
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Personaje_Pelota")
        {
            other.attachedRigidbody.AddForce(transform.up * push);
        }
    }
}
