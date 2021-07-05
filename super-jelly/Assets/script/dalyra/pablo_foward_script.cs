using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class pablo_foward_script : MonoBehaviour
{
    #region Variables
    public float push;
    #endregion
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.name == "Personaje_Pelota")
        {
            other.attachedRigidbody.AddForce(transform.up * push);
        }
    }
}
